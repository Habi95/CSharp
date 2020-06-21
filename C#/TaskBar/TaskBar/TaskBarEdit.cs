using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLogic;

namespace TaskBar
{
    public partial class TaskBarEdit : Form
    {
        Controller controller;
        public TaskBarEdit()
        {
            InitializeComponent();
        }   
        public TaskBarEdit(ref Controller controller)
        {
            InitializeComponent();
        }
    }
}
