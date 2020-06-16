using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using WoerterBuchData;
using WoerterBuchData.model;

namespace Woerterbuchlogic
{
    public class WoerterbuchController
    {
        private string path;

        private string Url;


        //"Server=localhost; database=woerterbuch;UID=root"
        /// <summary>
        /// words in dictionary
        /// </summary>
        /// 
        private Dictionary<string, List<string>> KeyValueWordDict = new Dictionary<string, List<string>>();
        
        List<string> valueWordLists;
        Alphabet myAlphabet = new Alphabet();
        //public string url = "Server=localhost; database=woerterbuch;UID=root";
        WoerterBuchData.DataBaseSql DBSQL;
        Word myWord;
        public WoerterbuchController(string url, string path)
        {
            this.path = path;
            this.Url = url;
            this.DBSQL = new WoerterBuchData.DataBaseSql(Url);
            myAlphabet.fillAlphabetList();            
        }

        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public Dictionary<string, List<string>> ReadDictionary()
        {

            /*
             * list<object>
             * object = new ( [0] [1] .. )
             * dic = object + list
             * dic[object].ADD(new object( [3] , [4])
             * 
             * 
*/
            string[] wordList = File.ReadAllLines(path);
            foreach (string word in wordList)
            {
                string[] wordColumns = word.Split(';');
                if (!KeyValueWordDict.ContainsKey(wordColumns[0]))
                {
                    valueWordLists = new List<string>();
                    KeyValueWordDict.Add(wordColumns[0], valueWordLists);
                    KeyValueWordDict[wordColumns[0]].Add(wordColumns[1]);
                }
                else if (KeyValueWordDict.ContainsKey(wordColumns[0]))
                {
                    KeyValueWordDict[wordColumns[0]].Add(wordColumns[1]);
                }
            }
            return KeyValueWordDict;
        }

        public bool AddItem(string germanWord, string englishWord)
        {
            bool IsAdded = false;
            if (KeyValueWordDict.ContainsKey(germanWord) && !KeyValueWordDict[germanWord].Contains(englishWord))
            {
                KeyValueWordDict[germanWord].Add(englishWord);
            }
            else if (!KeyValueWordDict.ContainsKey(germanWord))
            {
                valueWordLists = new List<string>();
                valueWordLists.Add(englishWord);
                KeyValueWordDict.Add(germanWord, valueWordLists);

            }
            else
            {
                IsAdded = true;
            }
            return IsAdded;
        }

        /// <summary>
        /// writes the dictionary to file
        /// </summary>
        public void WriteToFile()
        {
            FileStream fileStream = File.Open(path, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
            foreach (KeyValuePair<string, List<string>> entry in KeyValueWordDict)
            {
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    System.IO.File.AppendAllText(path, string.Format("{0}{1}{2}{3}", entry.Key, ";", entry.Value.ElementAt(i), "\n", Environment.NewLine));

                }

            }
        }

        /// <summary>
        /// filters the dictionary and returns a list
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="hasToStartsWith"></param>
        /// <returns></returns>
        public List<string> FindResults(string filterString, bool hasToStartsWith)
        {
            List<string> list;
            if (!hasToStartsWith)
            {
                list = KeyValueWordDict.
                        Where(x =>
                            x.Key.Contains(filterString))
                                .Select(x => x.Key).ToList();
            }
            else
            {
                list = KeyValueWordDict.
                        Where(x =>
                            x.Key.StartsWith(filterString))
                                .Select(x => x.Key).ToList();
            }
            return list;
        }
        public List<string> FindPerKey(string filterString)
        {
            return KeyValueWordDict.
                       Where(x =>
                           x.Key.Contains(filterString))
                             .SelectMany(x => x.Value).ToList();
        }

        public void InsertKeyWord(string Gword, string lang1, string lang2)
        {

            var insertMapper = new InsertMapper();
            insertMapper.Table = "word";
            insertMapper.ColumnValueDict.Add("word", Gword);
            insertMapper.ColumnValueDict.Add("national_code", lang1);
            DBSQL.InserWord(insertMapper);
            myWord = DBSQL.getID(Gword);
            CheckOtherLang(lang2);

        }

        public void InsertAllWord(string lang1, string lang2)
        {
            List<string> list = new List<string>();
            foreach (var item in myAlphabet.AlphabetList)
            {
                var list1 = FindResults(item, true);
                foreach (var item1 in list1)
                {
                    list.Add(item1);
                }
            }
            foreach (var word in list)
            {
                if (DBSQL.getID(word) == null)
                {
                    InsertKeyWord(word, lang1, lang2);
                }
                else
                {
                    continue;
                }


            }


        }
        public void CheckOtherLang(string lang2)
        {
            if (KeyValueWordDict.ContainsKey(this.myWord.WordName))
            {
                List<string> list = FindPerKey(this.myWord.WordName);
                InsertValueWord(list, lang2);
            }
        }

        public void InsertValueWord(List<string> eList, string lang2)
        {
            foreach (var item in eList)
            {
                var insertMapper = new InsertMapper();
                insertMapper.Table = "word";
                insertMapper.ColumnValueDict.Add("word", item);
                insertMapper.ColumnValueDict.Add("national_code", lang2);
                DBSQL.InserWord(insertMapper);
                Word Otherword = DBSQL.getID(item);
                var insertMappe = new InsertMapper();
                insertMappe.Table = "dictword";
                insertMappe.ColumnValueDict.Add("word1_id", this.myWord.Id.ToString());
                insertMappe.ColumnValueDict.Add("word2_id", Otherword.Id.ToString());
                DBSQL.InserWord(insertMappe);
            }


        }

        public Dictionary<string, List<string>> ImportchoicedLang(string nationalCode1, string nationalCode2)
        {
            KeyValueWordDict.Clear();
            KeyValueWordDict = DBSQL.ImportSelectedLangued(nationalCode1, nationalCode2);
            return KeyValueWordDict;
        }

        public bool DeleteWord(string word)
        {
            bool isdeleted;

            return isdeleted = DBSQL.DeleteWord(word);
        }

        public bool UpdateWord(string word, string updatedWord)
        {
            bool isUpdated;
            return isUpdated = DBSQL.UpdateWord(word, updatedWord);
        }

        /// <summary>
        /// returns the alphabet for the filtering
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlphabet()
        {
            return myAlphabet.AlphabetList;
        }
    }
}
