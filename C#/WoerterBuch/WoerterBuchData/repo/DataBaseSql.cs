using MySql.Data.MySqlClient;
using System;
using WoerterBuchData.model;

namespace WoerterBuchData
{
    public class DataBaseSql
    {
        private string URL;

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


        public Word getID(string wordForSearch)
        {
            Word word1;
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
            return word1 = new Word(id, word, nationalCode);

        }
    }
}
