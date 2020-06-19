using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLogic;

namespace TaskBar
{
    public partial class TaskBarForm : Form
    {
        Controller controller;
        public TaskBarForm()
        {
            InitializeComponent();
            timerNow.Start();
            controller = new Controller();
            //controller.newTask();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
            Datelabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void buttonAdded_Click(object sender, EventArgs e)
        {
            var dateTime = dateTimePicker1.Value;
            var toDo = richTextBoxTask.Text;
            controller.newTask(toDo, dateTime);
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

            var form = new TaskBarFormMenu(ref controller);
            this.Hide();
            form.Show();
        }
    }
}
