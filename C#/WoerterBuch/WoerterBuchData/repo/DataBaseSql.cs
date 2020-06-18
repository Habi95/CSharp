using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using WoerterBuchData.model;

namespace WoerterBuchData
{
    public class DataBaseSql
    {
        private string url;
        public string URL
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public DataBaseSql(string uRL)
        {
            URL = uRL;
        }
        public MySqlConnection myCon()
        {
            var connection = new MySqlConnection(URL);
            connection.Open();
            return connection;
        }
        public void InserWord(InsertMapper insertMapper)
        {
            try
            {
                var sqlInsert = $"INSERT INTO `{insertMapper.Table}`";
                var values = string.Empty;
                var columns = string.Empty;
                foreach (var item in insertMapper.ColumnValueDict)
                {
                    columns += string.IsNullOrEmpty(columns) ? $"`{item.Key}`" : $",`{item.Key}`";
                    values += string.IsNullOrEmpty(values) ? $"'{item.Value}'" : $",'{item.Value}'";

                }

                sqlInsert = $"{sqlInsert} ({columns}) VALUES ({values})";

                var connection = new MySqlConnection(URL);
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = sqlInsert;

                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {


            }


        }

        public Dictionary<string, List<string>> ImportSelectedLangued(string lang1, string lang2)
        {
            Dictionary<string, List<string>> lang = new Dictionary<string, List<string>>();
            try
            {
                //MySqlConnection connection = new MySqlConnection(URL);
                MySqlCommand command = myCon().CreateCommand();

                command.CommandText = $"SELECT {lang1}.word , {lang2}.word FROM `dictword`" +
                                      $" INNER JOIN word as {lang1} ON {lang1}.id = dictword.word1_id" +
                                      $" INNER JOIN word as {lang2} ON {lang2}.id = dictword.word2_id" +
                                      $" WHERE {lang1}.national_code = '{lang1}' && {lang2}.national_code = '{lang2}'";
                MySqlDataReader dataReader;
                //connection.Open();
                dataReader = command.ExecuteReader();
                using (dataReader)
                {


                    while (dataReader.Read())
                    {
                        if (!lang.ContainsKey(dataReader[0].ToString()))
                        {
                            List<string> list = new List<string>();
                            lang.Add(dataReader[0].ToString(), list);
                            lang[dataReader[0].ToString()].Add(dataReader[1].ToString());
                        }
                        else if (lang.ContainsKey(dataReader[0].ToString()))
                        {
                            lang[dataReader[0].ToString()].Add(dataReader[1].ToString());
                        }
                    }
                }
                if (lang.Count == 0)
                {

                    //MySqlConnection connection = new MySqlConnection(URL);
                    MySqlCommand command1 = myCon().CreateCommand();
                    command.CommandText = $"SELECT {lang1}.word , {lang2}.word FROM `dictword`" +
                                          $" INNER JOIN word as {lang1} ON {lang1}.id = dictword.word2_id" +
                                          $" INNER JOIN word as {lang2} ON {lang2}.id = dictword.word1_id" +
                                          $" WHERE {lang1}.national_code = '{lang1}' && {lang2}.national_code = '{lang2}'";
                    MySqlDataReader dataReader1;
                    //connection.Open();
                    dataReader1 = command.ExecuteReader();
                    using (dataReader1)
                    {


                        while (dataReader1.Read())
                        {
                            if (!lang.ContainsKey(dataReader1[0].ToString()))
                            {
                                List<string> list = new List<string>();
                                lang.Add(dataReader1[0].ToString(), list);
                                lang[dataReader1[0].ToString()].Add(dataReader1[1].ToString());
                            }
                            else if (lang.ContainsKey(dataReader1[0].ToString()))
                            {
                                lang[dataReader1[0].ToString()].Add(dataReader1[1].ToString());
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                List<string> list = new List<string>() { "DE / ENG,ITA" };
                lang.Add("Choice Right Language", list);
            }

            return lang;
        }


        public Word getID(string wordForSearch)
        {
            Word word1;
            try
            {
                MySqlConnection connection = new MySqlConnection(URL);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM `word` WHERE word = '{wordForSearch}'";
                MySqlDataReader dataReader;
                connection.Open();
                dataReader = command.ExecuteReader();
                int? id;
                string word;
                string nationalCode;
                dataReader.Read();
                id = Util.Extensions.StringExtension.ConvertType<int>(dataReader[0].ToString());
                word = dataReader[1].ToString();
                nationalCode = dataReader[2].ToString();
                word1 = new Word(id, word, nationalCode);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                word1 = null;

            }
            return word1;

        }

        public Dictionary<string, List<string>> getMostKeyValueID()
        {
            Dictionary<string, List<string>> idDict = new Dictionary<string, List<string>>();
            MySqlCommand command = myCon().CreateCommand();
            MySqlDataReader dataReader;

            command.CommandText = $"select word1_id, word2_id from dictword" +
                                    $" where word1_id in (" +
                                        $" SELECT word1_id FROM `dictword` group by word1_id having count(*) > 1)";

            using (dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var keyId = dataReader[0].ToString();


                    if (!idDict.ContainsKey(keyId))
                    {
                        List<string> valueIdList = new List<string>();
                        var valueId = dataReader[1].ToString();
                        idDict.Add(keyId, valueIdList);
                        idDict[keyId].Add(valueId);
                    }
                    else
                    {
                        var valueId = dataReader[1].ToString();
                        idDict[keyId].Add(valueId);
                    }

                }

            }
            return idDict;
        }
        public Word getWordByID(int id)
        {
            Word word = null;
            Dictionary<Word, List<Word>> dict = new Dictionary<Word, List<Word>>();
            MySqlCommand command = myCon().CreateCommand();
            MySqlDataReader dataReader;
            command.CommandText = $" SELECT * FROM `word` WHERE id = {id}";
            using (dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                word = new Word(id, dataReader[1].ToString(), dataReader[2].ToString());


            }

            return word;
        }

        public bool CheckLang(int? id1, int? id2)
        {
            bool isIn = false;
            try
            {
                MySqlCommand command = myCon().CreateCommand();
                command.CommandText = $"SELECT * FROM `dictword` WHERE word1_id = {id1} And word2_id = {id2}";
                MySqlDataReader dataReader;
                using (dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        isIn = true;
                        string test1 = dataReader[0].ToString();
                        string test2 = dataReader[1].ToString();
                    }
                }
            }
            catch (MySqlException)
            {

                isIn = false;
            }
            return isIn;
        }

        public bool DeleteWord(string toDelete)
        {
            bool isDeleted = false;
            try
            {
                MySqlConnection connection = new MySqlConnection(URL);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT onee.id , two.id FROM `dictword`" +
                $" INNER JOIN word as onee ON onee.id = word1_id" +
                $" INNER JOIN word as two On two.id = word2_id" +
                $" WHERE onee.word = '{toDelete}'";
                MySqlDataReader dataReader;
                connection.Open();
                List<int> idList = new List<int>();

                using (dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        var id1 = Util.Extensions.StringExtension.ConvertType<int>(dataReader[0].ToString());
                        if (id1.HasValue)
                        {
                            if (idList.Contains(id1.Value))
                            {
                                var id = Util.Extensions.StringExtension.ConvertType<int>(dataReader[1].ToString());
                                idList.Add(id.Value);
                            }
                            else
                            {
                                var id2 = Util.Extensions.StringExtension.ConvertType<int>(dataReader[1].ToString());
                                idList.Add(id1.Value);
                                idList.Add(id2.Value);
                            }
                        }
                    }
                }
                string sqlQuery = string.Empty;
                foreach (var item in idList)
                {
                    sqlQuery += string.IsNullOrEmpty(sqlQuery) ? $"DELETE FROM `word` WHERE id = {item}" : $"; DELETE FROM `word` WHERE id = {item} ";
                }


                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                isDeleted = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return isDeleted;

        }
        public bool UpdateWord(string word, string toUpdate)
        {
            bool isDeleted = false;
            try
            {
                MySqlConnection connection = new MySqlConnection(URL);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"UPDATE `word` SET `word`= '{toUpdate}' WHERE word = '{word}'";
                connection.Open();
                command.ExecuteNonQuery();
                isDeleted = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return isDeleted;

        }
    }
}
