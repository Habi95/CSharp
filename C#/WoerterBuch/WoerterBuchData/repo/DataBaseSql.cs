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

        public void InserWord(InsertMapper insertMapper)
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

        public Dictionary<string, List<string>> ImportSelectedLangued(string lang1, string lang2)
        {
            Dictionary<string, List<string>> lang = new Dictionary<string, List<string>>();
            try
            {
 MySqlConnection connection = new MySqlConnection(URL);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT {lang1}.word , {lang2}.word FROM `dictword`" +
                                  $" INNER JOIN word as {lang1} ON {lang1}.id = dictword.word1_id" +
                                  $" INNER JOIN word as {lang2} ON {lang2}.id = dictword.word2_id" +
                                  $" WHERE {lang1}.national_code = '{lang1}' && {lang2}.national_code = '{lang2}'";
            MySqlDataReader dataReader;
            connection.Open();
            dataReader = command.ExecuteReader();

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
            catch (Exception)
            {
                List<string> list = new List<string>() {"DE / ENG,ITA"};
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

        public bool DeleteWord (string toDelete)
        {
            bool isDeleted = false;
            try
            {
            MySqlConnection connection = new MySqlConnection(URL);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM `word` WHERE word = {toDelete}";
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
        public bool UpdateWord(string word,string toUpdate)
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
