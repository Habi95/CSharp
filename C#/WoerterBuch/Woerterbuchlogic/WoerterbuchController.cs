﻿using System;
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

        private string keyWord;
        private string valueWord;
        private bool IsAdded = false;


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

        public bool AddItem(string key_Word, string value_Word, string lang1, string lang2)
        {
            IsAdded = false;
            this.keyWord = key_Word;
            this.valueWord = value_Word;
            if (KeyValueWordDict.ContainsKey(keyWord) && !KeyValueWordDict[keyWord].Contains(valueWord))
            {
                KeyValueWordDict[keyWord].Add(valueWord);
            }
            else if (!KeyValueWordDict.ContainsKey(keyWord))
            {
                valueWordLists = new List<string>();
                valueWordLists.Add(valueWord);
                KeyValueWordDict.Add(keyWord, valueWordLists);

            }
            else
            {
                IsAdded = true;
            }
            if (!IsAdded)
            {
                InsertWord(lang1, lang2);
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

        public void InsertWord(string lang1, string lang2)
        {


            myWord = DBSQL.getID(keyWord);
            Word values = DBSQL.getID(valueWord);


            if (values == null && myWord != null)
            {
                List<string> tempList = new List<string>() { valueWord };
                InsertValueWord(tempList, lang2);
            }
            else
            {
                InsertKeyWord(keyWord, lang1, lang2);

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
                InsertDictLink(myWord, Otherword);

            }


        }
        public void InsertDictLink(Word keyWordd, Word valueWordd)
        {
            var insertMappe = new InsertMapper();
            insertMappe.Table = "dictword";
            insertMappe.ColumnValueDict.Add("word1_id", keyWordd.Id.ToString());
            insertMappe.ColumnValueDict.Add("word2_id", valueWordd.Id.ToString());
            DBSQL.InserWord(insertMappe);
            keyWord = string.Empty;
            valueWord = string.Empty;
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

        public void pairDict()
        {
            Dictionary<string, List<string>> idDict = DBSQL.getMostKeyValueID();
            foreach (var item in idDict)
            {
                Dictionary<Word, List<Word>> keyValuePairs = new Dictionary<Word, List<Word>>();
                List<Word> wordList = new List<Word>();
                List<string> list = idDict.Where(x =>
                                        x.Key.Contains(item.Key))
                                            .SelectMany(x => x.Value).ToList();
                foreach (var item1 in list)
                {

                    var id = Util.Extensions.StringExtension.ConvertType<int>(item1.ToString());
                    Word word = DBSQL.getWordByID(id.Value);
                    wordList.Add(word);
                }

                Word lang = null;
                for (int i = 0; i < wordList.Count; i++)
                {
                    if (lang == null)
                    {
                        lang = wordList.ElementAt(i);
                    }
                    else
                    {

                        var lang2 = wordList.ElementAt(i);
                        if (!lang.NationalCode.Equals(lang2.NationalCode))
                        {
                            foreach (var item3 in wordList)
                            {
                                if (lang != item3)
                                {
                                    if (!keyValuePairs.ContainsKey(lang))
                                    {
                                        List<Word> wList = new List<Word>();
                                        keyValuePairs.Add(lang, wList);
                                        keyValuePairs[lang].Add(item3);
                                    }
                                    else
                                    {
                                        keyValuePairs[lang].Add(item3);
                                    }


                                }

                            }
                        }
                    }
                }
                
                        foreach (var item6 in keyValuePairs)
                        {
                    for (int i = 0; i < item6.Value.Count; i++)
                    {
                        if (!DBSQL.CheckLang(item6.Key.Id, item6.Value.ElementAt(i).Id))
                        {
                        InsertDictLink(item6.Key, item6.Value.ElementAt(i));
                        }
                    
                    }
                   
                        }


                    
                

            }

        }

    }
}
