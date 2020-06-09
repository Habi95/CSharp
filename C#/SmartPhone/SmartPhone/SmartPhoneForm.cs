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
    public partial class SmartPhoneForm : Form
    {
        SmartAppListForm smartAppListForm = new SmartAppListForm();
        public SmartPhoneForm()
        {
            InitializeComponent();
            timer1.Start();
            smartAppListForm.Hide();


        }

        private void GoToListBtn_Click(object sender, EventArgs e)
        {            
            smartAppListForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimeHome.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
