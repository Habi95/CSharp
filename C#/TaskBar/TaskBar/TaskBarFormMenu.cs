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
    /*
     * 
     * 
     * TODO: when time to do the task nearly one hour before then show up in a pop up
     * 
     * 
     */
  
    public partial class TaskBarFormMenu : Form
    {
        Controller controller;
        List<task_bar> taskList = new List<task_bar>();
        public TaskBarFormMenu()
        {
            
            InitializeComponent();
        }
        public TaskBarFormMenu(ref Controller  controller)
        {
            InitializeComponent();
            timerNow2.Start();
            this.controller =  controller;
            taskList = controller.getAllTask();
            UpdateListBox();
            
            
        }    
        
         

        private void UpdateListBox ()
        {

            listBoxToDos.DataSource = taskList.OrderBy(x => x.dateTime).Select(x => $"{x.id} - {x.toDo} - {x.dateTime}").ToList();           
           

        }

        private void Reload()
        {
            taskList = controller.getAllTask();
            UpdateListBox();
        }

        private void timerNow2_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString("HH:mm:ss");
            Datelabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void buttonDutyOnDate_Click(object sender, EventArgs e)
        {
            taskList = controller.GetTaskByDate(dateTimePicker.Value.Date);
            UpdateListBox();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            taskList = controller.GetTaskByDate(null);
            UpdateListBox();
        }

       

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            controller.RemoveTask(listBoxToDos.SelectedItem as string);
            Reload();
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            var form = new TaskBarForm(ref controller);
            this.Hide();
            form.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            var form = new TaskBarEdit(ref controller, listBoxToDos.SelectedItem as string );
            this.Hide();
            form.Show();
        }
    }
}
