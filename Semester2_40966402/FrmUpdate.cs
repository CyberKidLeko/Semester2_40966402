using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Semester2_40966402
{
    public partial class FrmUpdate : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ViewForm viewForm = new ViewForm();
                int id = int.Parse(txtID.Text);
                cnn = new SqlConnection(viewForm.conString);
                cnn.Open();
                string query = $"Update Famous set Quote Where ID =  " + id ;
                cmd = new SqlCommand(query, cnn);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                adapter.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();

                viewForm.dataGridView1.DataSource = ds;
                viewForm.dataGridView1.DataMember = "Famous";
            }
            catch(Exception ex)
            {

            }
        }
    }
}
