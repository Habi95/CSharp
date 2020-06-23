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
            treeViewDepartment.AllowDrop = true;
            treeViewDepartment.Dock = DockStyle.Fill;
            UpdateTree();
            treeViewDepartment.ItemDrag += new ItemDragEventHandler(treeViewDepartment_ItemDrag);
            treeViewDepartment.DragEnter += new DragEventHandler(treeViewDepartment_DragEnter);
            treeViewDepartment.DragOver += new DragEventHandler(treeViewDepartment_DragOver);
            treeViewDepartment.DragDrop += new DragEventHandler(treeViewDepartment_DragDrop);
            
        }
        private void UpdateTree()
        {
            treeViewDepartment.Nodes.Clear();
            staffList = controller.GetAllDep();
            fillComboBox();
            comboBoxParent.DisplayMember = "department";                      
            fillTree(null, null);
            treeViewDepartment.ExpandAll();
            textBoxSubDepartment.Clear();
            textBoxNewSuperior.Clear();
        }

        private void fillComboBox()
        {
            comboBoxParent.DataSource = staffList;
        }

        private void fillTree(Staff key, TreeNode Pkey)
        {
            TreeNode child;
            foreach (var item in (key == null) ? controller.GetBosses() : key.Staff1)
            {
                if(Pkey == null)
                {
                    child = treeViewDepartment.Nodes.Add(item.id.ToString(), item.department);
                }
                else
                {
                    child = Pkey.Nodes.Add(item.id.ToString(), item.department);
                }
                fillTree(item, child);
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Staff superior = (Staff)comboBoxParent.SelectedItem;
            var sub = textBoxSubDepartment.Text;
            var newSuperior = textBoxNewSuperior.Text;
            controller.AddStaff(superior.id, sub,newSuperior);
            UpdateTree(); 
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            controller.RemoveStaff((Staff)comboBoxParent.SelectedItem);
            UpdateTree();
        }

        private void treeViewDepartment_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeViewDepartment.PointToClient(new Point(e.X, e.Y));


            treeViewDepartment.SelectedNode = treeViewDepartment.GetNodeAt(targetPoint);
        }

        private void treeViewDepartment_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void treeViewDepartment_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeViewDepartment.PointToClient(new Point(e.X, e.Y));

           
            TreeNode targetNode = treeViewDepartment.GetNodeAt(targetPoint);

           
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                }

                
                targetNode.Expand();
            }
        }

        private void treeViewDepartment_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }
        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
           
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;            
            controller.DragUpdate(node2.Text, node1.Text);
            return ContainsNode(node1, node2.Parent);
        }
    }
}
