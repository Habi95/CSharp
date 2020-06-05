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

namespace Einkaufswagen
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> shoppingDict = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateShopping()
        {

            listBoxShoppingList.DataSource = shoppingDict.Select(x => $"{x.Key} ( {x.Value} )").ToList();

            //foreach (var item in shoppingDict.Keys)
            //{
            //    listBoxShoppingList.Items.Add($"{item.ToString()} ( {shoppingDict[item]} )");
            //}




        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            string product = tbProduct.Text;
            int count = Convert.ToInt32(tbCount.Text);

            if (!string.IsNullOrEmpty(product) && count > 0)
            {
                if (shoppingDict.ContainsKey(product))
                {
                    shoppingDict[product] += count;
                    UpdateShopping();
                }
                else
                {
                    shoppingDict.Add(product, count);
                    UpdateShopping();
                }

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string product = tbProduct.Text;
            int count = Convert.ToInt32(tbCount.Text);

            if (!string.IsNullOrEmpty(product) && count > 0 && shoppingDict.ContainsKey(product))
            {
                shoppingDict[product] -= count;
                if (shoppingDict[product] <= 0)
                {
                    shoppingDict.Remove(product);
                    UpdateShopping();
                }
                UpdateShopping();



            }

        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            DictFileWriter();
        }
        private void DictFileWriter()
        {
            FileStream fileStream = File.Open("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\Einkaufsliste.csv", FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
            foreach (KeyValuePair<string, int> entry in shoppingDict)
            {
                System.IO.File.AppendAllText("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\Einkaufsliste.csv", string.Format("{0}{1}{2}{3}", entry.Key, ";", entry.Value, "\n", Environment.NewLine));

            }
        }
    }
}
