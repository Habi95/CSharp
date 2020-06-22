using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            var taskList = checkDate(task);
            return taskList;
        }

        public List<task_bar> checkDate(List<task_bar> task)
        {
            List<task_bar> list = new List<task_bar>();
            foreach (var item in task)
            {
                if (item.dateTime.Day >= DateTime.Now.Day && item.dateTime.Month >= DateTime.Now.Month && item.dateTime.Year >= DateTime.Now.Year)
                {

                    item.expired = false;
                    list.Add(item);


                }
                else
                {
                    entities.task_bar.Remove(item);
                    entities.SaveChanges();
                }



            }

            return list;

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
        public task_bar GetTaskById (string task)
        {
            var taskArray = task.Split('-');
            int? taskId = Util.Extensions.StringExtension.ConvertType<int>(taskArray[0]);
            task_bar taskObject = null;
            if (taskId.HasValue)
            {
                var tasks = entities.task_bar.Where(x => x.id == taskId.Value).ToList();
                taskObject = tasks.ElementAt(0);
            }
            return taskObject;
        }

        public void UpdateTask (string task)
        {
            task_bar taskObject = GetTaskById(task); 
            var toUpdateTask = task.Split('-');
            int? taskId = Util.Extensions.StringExtension.ConvertType<int>(toUpdateTask[0]);
            DateTime? date_time = Util.Extensions.StringExtension.ConvertType<DateTime>(toUpdateTask[2]);
            if (taskId.HasValue && date_time.HasValue)
            {
               
                taskObject.id = taskId.Value;
                taskObject.toDo = toUpdateTask[1];
                taskObject.dateTime = date_time.Value;
                taskObject.done = false;
                taskObject.expired = false;
               // entities.task_bar.Add(taskObject);
                entities.SaveChanges();

            }
        }

        public void RemoveTask(string task)
        {
            var toRemovedTask = task.Split('-');
            int? removeId = Util.Extensions.StringExtension.ConvertType<int>(toRemovedTask[0]);
            if (removeId.HasValue)
            {
                var tasks = entities.task_bar.Where(x => x.id == removeId.Value).ToList();
                foreach (var item in tasks)
                {
                    entities.task_bar.Remove(item);
                    entities.SaveChanges();
                }

            }

        }

    }
}
