using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskData;
using TaskLogic;

namespace TaskBar
{
    public partial class TaskBarEdit : Form
    {
        Controller controller;
        private task_bar task_bar;
        
        public TaskBarEdit()
        {
            InitializeComponent();
            timer.Start();
        }   
        public TaskBarEdit(ref Controller actController, string selectedTask)
        {
            InitializeComponent();
            timer.Start();
            controller = actController;
            task_bar = controller.GetTaskById(selectedTask);
            richTextBox.Text = selectedTask;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
            Datelabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

       

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            controller.RemoveTask(richTextBox.Text);
            task_bar = null;
            richTextBox.Text = "";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var form = new TaskBarFormMenu(ref controller);
            this.Hide();
            form.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            controller.UpdateTask(richTextBox.Text);

        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            var form = new TaskBarForm(ref controller);
            this.Hide();
            form.Show();
        }
    }
}
