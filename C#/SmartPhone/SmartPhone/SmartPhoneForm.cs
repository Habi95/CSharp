using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;

namespace SmartPhone
{
    public partial class SmartPhoneForm : Form
    {

        SmartPhoneController.Controller smartController;
        SmartAppListForm smartAppListForm; 
        
        
        public SmartPhoneForm()
        {
            InitializeComponent();
            smartController = new SmartPhoneController.Controller(new DataModels.SmartPhone("Samsung s10+", "Blue Metallic"));
            smartController.loadAppList();
            smartAppListForm = new SmartAppListForm(smartController);
            timer1.Start();
            
            
        }       
    
        private void GoToListBtn_Click(object sender, EventArgs e)
        {

            smartAppListForm.StartPosition = FormStartPosition.CenterScreen;
            smartAppListForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimeHome.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
