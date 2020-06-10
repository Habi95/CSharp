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
        Woerterbuchlogic.WoerterbuchController controller = new Woerterbuchlogic.WoerterbuchController("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.csv");
        Dictionary<string, List<string>> germanToEnglishDict = new Dictionary<string, List<string>>();
        List<string> englishwordLists;
        bool hasToStartsWith = false;

        public BackGround()
        {
            InitializeComponent();            
            controller.ReadDictionary();
            UpdateTranslation();
            UpdateAlphabet();
        }




        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            string germanWord = tbGermanWord.Text;
            string englishWord = tbEnglishWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                if (!controller.AddItem(germanWord, englishWord))
                {
                    UpdateTranslation();
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
            controller.ReadDictionary();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hasToStartsWith = false;
            listBoxTranslation.DataSource = controller.FindPerKey(textBoxSearch.Text);
            lbGermanWords.DataSource = controller.FindResults(textBoxSearch.Text, hasToStartsWith);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            btnSearch_Click(null, null);

        }


        private void UpdateTranslation()
        {
            lbGermanWords.DataSource = germanToEnglishDict.Keys.OrderBy(myWord => myWord).ToList();
        }
        private void UpdateAlphabet()
        {
            listBoxAlphabet.DataSource = controller.GetAlphabet();
        }


    }
}
