using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester2_40966402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm(); //Instance of the view form
            viewForm.MdiParent= this;
            viewForm.Show(); // show the form
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminForm= new AdminForm();
            adminForm.MdiParent= this;
            adminForm.Show();
        }
    }
}
