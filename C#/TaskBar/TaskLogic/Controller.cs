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
        

        public void newTask(string doTo,DateTime dateTime)
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

        public task_bar GetTask ()
        {
            var task = entities.task_bar.Where(x => x.toDo == "Einkaufen").FirstOrDefault();
            return task;
        }

    }
}
