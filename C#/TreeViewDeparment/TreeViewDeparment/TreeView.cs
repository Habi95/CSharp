using DeparmentData;
using DepartmentController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDeparment
{
    public partial class TreeView : Form
    {
        /*
         * var node = treeView1.Nodes.Add("1", "Vorstand"); // 1. Ebene
         * var nodeN = node.Nodes.Add("2", "Vertrieb"); // 2. Ebene
         * var nodeVertrieb = nodeN.Nodes.Add("3", "Verkauf Kleinteile"); //3. ebene 
         *
         */
        Controller controller;
        List<Staff> staffList = new List<Staff>();
        public TreeView()
        {
            InitializeComponent();
            controller = new Controller();
            staffList = controller.GetAllDep();
            fillComboBox();
            fillTree();
            //controller.AddStaff();

        }

        private void fillComboBox()
        {
            foreach (var item in staffList)
            {
                comboBoxParent.Items.Add(item.department);
            }
        }

        private void fillTree()
        {
            //TODO Rekursion
            TreeNode node = treeViewDepartment.Nodes.Add($"{staffList.ElementAt(0).department}", staffList.ElementAt(0).department);
            node.Tag = staffList.ElementAt(0);
            if (staffList.ElementAt(0).Staff1.Count > 0)
            {
                foreach (var item in staffList.ElementAt(0).Staff1)
                {
                    var nodeSub = treeViewDepartment.Nodes[item.Staff2.department].Nodes.Add($"{item.department}", item.department);
                    if (item.Staff1.Count > 0)
                    {
                        foreach (var item2 in item.Staff1)
                        {
                            var nodeSubb = treeViewDepartment.Nodes.Find(item2.Staff2.department,true).FirstOrDefault().Nodes.Add($"{item2.department}", item2.department);
                        }

                    }
                }


            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
