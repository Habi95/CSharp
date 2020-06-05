using PersonFileReader.model;
using System;
using System.Collections.Generic;
using System.IO;

namespace PersonFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            string []  personWithoutJob = System.IO.File.ReadAllLines("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\persons.txt");

            foreach (string personinfo in personWithoutJob)
            {
                string[] perColumn = personinfo.Split(";");
                int.TryParse(perColumn[1], out int age);
                Person person = new Person()
                {
                    Name = perColumn[0],
                    Age = age,
                    LivingPlace = perColumn[2],
                    Job = perColumn[0] == "Hans" || perColumn[0] == "Helga" ? "Coder" : "Officer"
                };
                personsList.Add(person);
            }
            List<string> personsListWithJob = new List<string>();
            foreach (Person person in personsList)
            {
                personsListWithJob.Add($"{person.Name};{person.Age};{person.LivingPlace};{person.Job}");
            }
            File.WriteAllLines("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\peronwithJob.txt", personsListWithJob);
        }
    }
}
