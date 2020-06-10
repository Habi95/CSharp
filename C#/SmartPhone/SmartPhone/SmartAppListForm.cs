using DataModels;
using Einkaufswagen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPhone
{
    public partial class SmartAppListForm : Form
    {
        SmartPhoneController.Controller controller;
        public SmartAppListForm()
        {
            InitializeComponent();
            timer.Start();
        }
        public SmartAppListForm(SmartPhoneController.Controller smart)
        {

            InitializeComponent();
            controller = smart;
            timer.Start();
            UpdateListBox();
            UpdateKomboBox();
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        public void UpdateListBox()
        {
            listBoxApp.DataSource = controller.showApps();

        }
        public void UpdateKomboBox()
        {
            comboBoxApps.DataSource = controller.showComboBox();
          
        }

        private void listBoxApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimeMenu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            
        }

        private void comboBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxApp.DataSource = controller.getByAppType(comboBoxApps.SelectedItem as string);
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            string selectedApp = listBoxApp.SelectedItem as string;
           string[] splitt =  selectedApp.Split();

            if (splitt[0].Equals("Wörterbuch"))
            {
                WoerterBuch.BackGround dict = new WoerterBuch.BackGround();
                dict.StartPosition = FormStartPosition.CenterScreen;
                dict.ShowDialog();
            }
            else if (splitt[0].Equals("Einkaufsliste"))
            {
                Form1 form = new Form1();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
            else 
            {
                controller.startSnake();
                //MessageBox.Show(controller.showAppPerName(splitt[0]));
            }
        }
    }
}
