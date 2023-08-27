using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semester2_40966402
{
    public partial class ViewForm : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nkulu\source\repos\Semester2_40966402\Semester2_40966402\Quotes.mdf;Integrated Security=True";
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(conString);
                cnn.Open();
                string query = "SELECT * FROM Famous";
                cmd= new SqlCommand(query, cnn);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Famous");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Famous";

                string query2 = "SELECT DISTINCT FirstName FROM Famous";
                cmd = new SqlCommand(query2, cnn);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Famous");

                cmbNames.DisplayMember = "Name"; 
                cmbNames.ValueMember= "Name";
                cmbNames.DataSource = ds.Tables["Famous"];

                hsbYear.Minimum = 0;
                hsbYear.Maximum = 4000;
                hsbYear.SmallChange = 1;
                hsbYear.LargeChange = 100;




                cnn.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            



        }

        private void hsbYear_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                lblYearScrollBar.Text = hsbYear.Value.ToString();
                int year = int.Parse(lblYearScrollBar.Text);
                cnn = new SqlConnection(conString);
                cnn.Open();
                string query = "SELECT * FROM Famous WHERE YearSaid = " + lblYearScrollBar.Text;
                cmd = new SqlCommand(query, cnn);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Famous");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Famous";


                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRemoveFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(conString);
                cnn.Open();
                string query = "SELECT * FROM Famous";
                cmd = new SqlCommand(query, cnn);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Famous");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Famous";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
