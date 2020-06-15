using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WoerterBuchData;
using WoerterBuchData.model;

namespace Woerterbuchlogic
{
    public class WoerterbuchController
    {
        private string path;


        /// <summary>
        /// words in dictionary
        /// </summary>
        private Dictionary<string, List<string>> germanToEnglishDict = new Dictionary<string, List<string>>();
        List<string> englishwordLists;
        Alphabet myAlphabet = new Alphabet();
        //public string url = "Server=localhost; database=woerterbuch;UID=root";
        WoerterBuchData.DataBaseSql DBSQL = new WoerterBuchData.DataBaseSql("Server=localhost; database=woerterbuch;UID=root");
        Word myWord;
        public WoerterbuchController(string path)
        {
            this.path = path;
            myAlphabet.fillAlphabetList();
        }




        /// <summary>
        /// read the file to the dictionary
        /// wordsDict
        /// </summary>
        public void ReadDictionary()
        {

            string[] wordList = File.ReadAllLines(path);
            foreach (string word in wordList)
            {
                string[] wordColumns = word.Split(';');
                if (!germanToEnglishDict.ContainsKey(wordColumns[0]))
                {
                    englishwordLists = new List<string>();
                    germanToEnglishDict.Add(wordColumns[0], englishwordLists);
                    germanToEnglishDict[wordColumns[0]].Add(wordColumns[1]);
                }
                else if (germanToEnglishDict.ContainsKey(wordColumns[0]))
                {
                    germanToEnglishDict[wordColumns[0]].Add(wordColumns[1]);
                }




            }
        }

        public bool AddItem(string germanWord, string englishWord)
        {
            bool IsAdded = false;
            if (germanToEnglishDict.ContainsKey(germanWord) && !germanToEnglishDict[germanWord].Contains(englishWord))
            {
                germanToEnglishDict[germanWord].Add(englishWord);
            }
            else if (!germanToEnglishDict.ContainsKey(germanWord))
            {
                englishwordLists = new List<string>();
                englishwordLists.Add(englishWord);
                germanToEnglishDict.Add(germanWord, englishwordLists);

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
            foreach (KeyValuePair<string, List<string>> entry in germanToEnglishDict)
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
                list = germanToEnglishDict.
                        Where(x =>
                            x.Key.Contains(filterString))
                                .Select(x => x.Key).ToList();
            }
            else
            {
                list = germanToEnglishDict.
                        Where(x =>
                            x.Key.StartsWith(filterString))
                                .Select(x => x.Key).ToList();
            }
            return list;
        }
        public List<string> FindPerKey(string filterString)
        {          
            return germanToEnglishDict.
                       Where(x =>
                           x.Key.Contains(filterString))
                             .SelectMany(x => x.Value).ToList();
        }

        public void InsertGermanWord(string Gword)
        {
            
            var insertMapper = new InsertMapper();
            insertMapper.Table = "word";
            insertMapper.ColumnValueDict.Add("word", Gword);
            insertMapper.ColumnValueDict.Add("national_code", NationalCode.DE.ToString());
            DBSQL.InserWord(insertMapper);
            myWord = DBSQL.getID(Gword);
            CheckOtherLang();

        }

        public void InsertAllWord ()
        {
            List<string> list = new List<string>();
            foreach (var item in myAlphabet.AlphabetList)
            {
                 var list1 =  FindResults(item, true);
                foreach (var item1 in list1)
                {
                    list.Add(item1);
                }
            }
            foreach (var word in list)
            {
                InsertGermanWord(word);
            }
            

        }
        public void CheckOtherLang()
        {
            if (germanToEnglishDict.ContainsKey(this.myWord.WordName))
            {
                List<string> list = FindPerKey(this.myWord.WordName);
                InsertEnglishWord(list);
            }
        }

        public void InsertEnglishWord(List<string> eList)
        {
            foreach (var item in eList)
            {
                var insertMapper = new InsertMapper();
                insertMapper.Table = "word";
                insertMapper.ColumnValueDict.Add("word", item);
                insertMapper.ColumnValueDict.Add("national_code", NationalCode.ENG.ToString());
                DBSQL.InserWord(insertMapper);
                Word Otherword = DBSQL.getID(item);
                var insertMappe = new InsertMapper();      
                insertMappe.Table = "dictword";
                insertMappe.ColumnValueDict.Add("word1_id", this.myWord.Id.ToString());
                insertMappe.ColumnValueDict.Add("word2_id", Otherword.Id.ToString());
                DBSQL.InserWord(insertMappe);               
            }


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
