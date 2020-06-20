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
     * TODO:check if current task are expiere when then delete 
     * TODO: when time to do the task nearly one hour before then show up in a pop up
     * TODO: option to edit the task other date or other time
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

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            taskList = controller.getAllTask();
            UpdateListBox();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            controller.RemoveTask(listBoxToDos.SelectedItem as string);
        }
    }
}
