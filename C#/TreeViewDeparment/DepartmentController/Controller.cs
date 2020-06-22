using DeparmentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentController
{
    public class Controller
    {
        //staff2 parent Object
        //staff1 child object in List

        DeparmentTreeEntities entities = new DeparmentTreeEntities();
        List<Staff> staffList = new List<Staff>();

        public List<Staff> GetAllDep()
        {
            Staff boss = entities.Staff.Where(x => x.department == "Vertrieb Österreich").FirstOrDefault();
            Staff newStaff = new Staff();
            newStaff.parent_id = boss.id;
            newStaff.department = "Vertrieb Vorarlberg";
            entities.Staff.Add(newStaff);
            entities.SaveChanges();
            staffList = entities.Staff.ToList();
            return staffList;
        }

        public void AddStaff()
        {

           
        }
            /* Staff staff = new Staff();
             staff.department = "Vorstand";
             entities.Staff.Add(staff);
             entities.SaveChanges();
            Staff boss = entities.Staff.Where(x => x.department == "Vertrieb").FirstOrDefault();
            Staff staff2 = boss.Staff2;
            Staff newStaff = new Staff();
            newStaff.parent_id = staff2.id;
            newStaff.department = "Human Ressources";
            entities.Staff.Add(newStaff);
            entities.SaveChanges();
            Staff boss2 = entities.Staff.Where(x => x.department == "Vorstand").FirstOrDefault();
            foreach (var item in boss2.Staff1)
            {
                staffList.Add(item);

            }
            var list = staff2.Staff1;
            staff2.department = "Vertrieb";
            staff2.parent_id = boss.id;
            entities.Staff.Add(staff2);
            entities.SaveChanges();*/

    }
}
