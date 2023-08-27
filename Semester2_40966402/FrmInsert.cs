using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Semester2_40966402
{
    public partial class FrmInsert : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adapter;
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(txtIDInsert.Text);
                string name = txtNameInsert.Text;
                string surname  = txtSurnameInsert.Text;   
                int yearSaid = int.Parse(txtYearInsert.Text);
                string quote = rtxtQuoteInsert.Text;

                if (ID == null)
                {
                    IdErrorProvider.Equals("Enter correct value");
                }
                else if (name == string.Empty)
                {
                    nameErrorProvider.Equals("Enter correct value");
                }
                else if(surname== string.Empty)
                {
                    surnameErrorProvider.Equals("Enter correct value");
                }
                else if (yearSaid == null)
                {
                    yearSaidErrorProvider.Equals("Enter correct value");
                }
                else if (quote == string.Empty)
                {
                    quoteErrorProvider.Equals("Enter correct value");
                }

                ViewForm viewForm = new ViewForm();

                cnn = new SqlConnection(viewForm.conString);
                cnn.Open();
                string query = $"INSERT INTO Famous(ID, FirstName, LastName, YearSaid, Quote) VALUES ({ID}, '{name}', '{surname}', {yearSaid}, '{quote}') ";
                cmd = new SqlCommand(query, cnn);
                ds = new DataSet();
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                cmd.ExecuteNonQuery();

                viewForm.dataGridView1.DataSource = ds;
                viewForm.dataGridView1.DataMember = "Famous";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
