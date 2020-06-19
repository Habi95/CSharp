using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskData;

namespace TaskLogic
{
    public class Controller
    {

        TaskEntities entities = new TaskEntities();


        public void newTask(string doTo, DateTime dateTime)
        {
            task_bar task = new task_bar();
            task.toDo = doTo;
            task.dateTime = dateTime;
            task.done = false;
            task.expired = false;

            entities.task_bar.Add(task);
            entities.SaveChanges();
            // var task = entities.task_bar.Where(x => x.toDo == "Einkaufen).FirstOrDefault();"
        }

        public List<task_bar> getAllTask()
        {
            var task = entities.task_bar.ToList();
            return task;
        }

        public List<task_bar> GetTaskByDate(DateTime? date)
        {

            List<task_bar> tasks;
            if (date.HasValue)
            {
                tasks = entities.task_bar.Where(x => x.dateTime.Day == date.Value.Day && x.dateTime.Month == date.Value.Month && x.dateTime.Year == date.Value.Year).ToList();


            }
            else
            {
                var dayBegin = DateTime.Today;
                var dayEnd = DateTime.Today.AddHours(24).AddSeconds(-1);
                tasks = entities.task_bar.Where(x => x.dateTime >= dayBegin && x.dateTime <= dayEnd).ToList();
            }



            return tasks;
        }

    }
}
