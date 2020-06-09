using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoerterBuch
{
    public partial class BackGround : Form
    {
        Dictionary<string, List<string>> germanToEnglishDict = new Dictionary<string, List<string>>();
        List<string> englishwordLists;
        Alphabet myAlphabet = new Alphabet();
        public BackGround()
        {
            InitializeComponent();
            ImportCSV();
            myAlphabet.fillAlphabetList();
            UpdateTranslation();
            UpdateAlphabet();
        }




        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            string germanWord = tbGermanWord.Text;
            string englishWord = tbEnglishWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                if (germanToEnglishDict.ContainsKey(germanWord) && !germanToEnglishDict[germanWord].Contains(englishWord))
                {
                    germanToEnglishDict[germanWord].Add(englishWord);
                }
                else if (!germanToEnglishDict.ContainsKey(germanWord))
                {
                    englishwordLists = new List<string>();
                    englishwordLists.Add(englishWord);
                    germanToEnglishDict.Add(germanWord, englishwordLists);
                    UpdateTranslation();
                }
                else
                {
                    string message = $"'{germanWord}' - '{englishWord}' Wurde bereits eingetragen";
                    MessageBox.Show(message, "Error");
                }


            }
        }
        private void lbGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = germanToEnglishDict
                .Where(x => x.Key.Contains(lbGermanWords.SelectedItem as string))
                .SelectMany(x => x.Value).ToList();
            listBoxTranslation.DataSource = list;            
        }


        private void listBoxAlphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = germanToEnglishDict.
                Where(x =>
                    x.Key.StartsWith(listBoxAlphabet.Text)).Select(x => x.Key).ToList();
            lbGermanWords.DataSource = list;
            lbGermanWords.ClearSelected();

        }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            DictFileWriter();
        }
        private void buttonImportCsv_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {                        
            listBoxTranslation.DataSource = germanToEnglishDict
             .Where(x =>
                 x.Key.Contains(textBoxSearch.Text)).SelectMany(x => x.Value).ToList();
            lbGermanWords.DataSource = germanToEnglishDict
                .Where(x =>
                x.Key.Contains(textBoxSearch.Text)).Select(x => x.Key).ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            btnSearch_Click(null, null);
            
        }


        private void DictFileWriter()
        {
            FileStream fileStream = File.Open("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.csv", FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
            //File.WriteAllText("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.txt", string.Empty);
            foreach (KeyValuePair<string, List<string>> entry in germanToEnglishDict)
            {
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    System.IO.File.AppendAllText("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.csv", string.Format("{0}{1}{2}{3}", entry.Key, ";", entry.Value.ElementAt(i), "\n", Environment.NewLine));

                }

            }
        }


        private void ImportCSV()
        {
            string[] wordList = File.ReadAllLines("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.csv");            
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


        private void UpdateTranslation()
        {
            lbGermanWords.DataSource = germanToEnglishDict.Keys.OrderBy(myWord => myWord).ToList();
        }
        private void UpdateAlphabet()
        {
            listBoxAlphabet.DataSource = myAlphabet.AlphabetList;
        }

       
    }
}
