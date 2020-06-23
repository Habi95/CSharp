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
            /*Staff boss = entities.Staff.Where(x => x.department == "Vertrieb Österreich").FirstOrDefault();
            Staff newStaff = new Staff();
            newStaff.parent_id = boss.id;
            newStaff.department = "Vertrieb Vorarlberg";
            entities.Staff.Add(newStaff);
            entities.SaveChanges();*/
            staffList = entities.Staff.ToList();
            return staffList;
        }

        public void AddStaff(int parentId, string Department, string newSuperior)
        {
            if (string.IsNullOrEmpty(newSuperior))
            {
                Staff isExisting = entities.Staff.Where(x => x.department.Equals(Department)).FirstOrDefault();
                if (isExisting == null)
                {
                    Staff staff = new Staff();
                    staff.parent_id = parentId;
                    staff.department = Department;
                    entities.Staff.Add(staff);
                    entities.SaveChanges();
                }
                else
                {
                    isExisting.parent_id = parentId;
                    entities.SaveChanges();
                }

            }
            else
            {
                Staff superior = new Staff();
                superior.department = newSuperior;
                entities.Staff.Add(superior);
                entities.SaveChanges();
            }



        }
        public void DragUpdate (string newParent, string newChild)
        {
            Staff newP = entities.Staff.Where(x => x.department.Equals(newParent)).FirstOrDefault();
            Staff newCh = entities.Staff.Where(x => x.department.Equals(newChild)).FirstOrDefault();
            newCh.parent_id = newP.id;
            entities.SaveChanges();
        }

        public void RemoveStaff(Staff staff)
        {
            entities.Staff.Remove(staff);
            entities.SaveChanges();
        }

        public List<Staff> GetBosses()
        {
            
            List<Staff> bosslist = new List<Staff>();
            foreach (var item in staffList)
            {
                if (item.parent_id == null)
                {
                    bosslist.Add(item);
                }

            }
            return bosslist;

        }

    }
}
