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
        public SmartAppListForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void listBoxApp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimeMenu.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
