using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        //C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.csv
        Woerterbuchlogic.WoerterbuchController controller;
        Dictionary<string, List<string>> KeyValueWordDict = new Dictionary<string, List<string>>();
        bool hasToStartsWith = false;


        public BackGround()
        {
            InitializeComponent();
            var url = ConfigurationManager.AppSettings.Get("DB_URL");
            var path = ConfigurationManager.AppSettings.Get("LocalPath");
            controller = new Woerterbuchlogic.WoerterbuchController(url, path);
            var languages = ConfigurationManager.AppSettings.Get("Languages");
            var langArray = languages.Split(';');
            fillCombo(langArray);
            UpdateAlphabet();
            KeyValueWordDict = controller.ImportchoicedLang(langArray[0], langArray[1]);
            textBoxOutput1.Text = langArray[0];
            textBoxOutput2.Text = langArray[1];
            UpdateTranslation();

        }


        public void fillCombo(Array language)
        {
            /* comboBoxLang1.Items.Add(language.GetValue(0));
             comboBoxLang2.Items.Add(language.GetValue(1));
             comboBoxLang2.Items.Add(language.GetValue(2));*/

            foreach (var item in language)
            {
                comboBoxLang1.Items.Add(item);
                comboBoxLang2.Items.Add(item);

            }
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            string germanWord = tbGermanWord.Text;
            string englishWord = tbEnglishWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                if (!controller.AddItem(germanWord, englishWord, textBoxOutput1.Text, textBoxOutput2.Text))
                {
                    UpdateTranslation();
                    tbGermanWord.Clear();
                    tbEnglishWord.Clear();
                }
                else
                {
                    string message = $"'{germanWord}' - '{englishWord}' Wurde bereits eingetragen";
                    MessageBox.Show(message, "Error");
                }

            }
            else
            {
                MessageBox.Show("Input is missing!", "Error");
            }
        }
        private void lbGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasToStartsWith = false;
            listBoxTranslation.DataSource = controller.FindPerKey(lbGermanWords.SelectedItem as string);
            textBoxDelete.Text = lbGermanWords.SelectedItem as string;
            textBoxUpdate.Text = lbGermanWords.SelectedItem as string;

        }
        private void listBoxTranslation_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDelete.Text = listBoxTranslation.SelectedItem as string;
            textBoxUpdate.Text = listBoxTranslation.SelectedItem as string;
        }


        private void listBoxAlphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasToStartsWith = true;
            lbGermanWords.DataSource = controller.FindResults(listBoxAlphabet.Text, hasToStartsWith);

        }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            controller.WriteToFile();
        }
        private void buttonImportCsv_Click(object sender, EventArgs e)
        {
            KeyValueWordDict = controller.ReadDictionary();
            UpdateTranslation();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hasToStartsWith = false;
            listBoxTranslation.DataSource = controller.FindPerKey(textBoxSearch.Text);
            lbGermanWords.DataSource = controller.FindResults(textBoxSearch.Text, hasToStartsWith);
            textBoxSearch.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            btnSearch_Click(null, null);

        }


        private void UpdateTranslation()
        {
            lbGermanWords.DataSource = KeyValueWordDict.Keys.OrderBy(myWord => myWord).ToList();
        }
        private void UpdateAlphabet()
        {
            listBoxAlphabet.DataSource = controller.GetAlphabet();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            controller.InsertAllWord(textBoxOutput1.Text, textBoxOutput2.Text);//InsertGermanWord(lbGermanWords.SelectedItem as string);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOutput1.Text = comboBoxLang1.SelectedItem as string;

        }

        private void comboBoxLang2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxOutput2.Text = comboBoxLang2.SelectedItem as string;
        }

        private void buttonImportDB_Click(object sender, EventArgs e)
        {
            string lang1 = textBoxOutput1.Text;
            string lang2 = textBoxOutput2.Text;
            if (!string.IsNullOrEmpty(lang1) && !string.IsNullOrEmpty(lang2))
            {
                KeyValueWordDict = controller.ImportchoicedLang(lang1, lang2);
                if (KeyValueWordDict.Count == 0)
                {
                    MessageBox.Show("Choice Right Language - DE / ENG,ITA");
                }
                else
                {
                    UpdateTranslation();
                    MessageBox.Show("Status OK");
                }

            }
            else
            {
                MessageBox.Show("Choiced Languages is Empty");
            }

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (controller.DeleteWord(textBoxDelete.Text))
            {
                MessageBox.Show("Successful Deleted");
            }
            else
            {
                MessageBox.Show("Something go Wrong");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (controller.UpdateWord(lbGermanWords.SelectedItem as string, textBoxUpdate.Text))
            {
                MessageBox.Show("Successful Updated");
            }
            else
            {
                MessageBox.Show("Something go Wrong");
            }

        }


    }
}
