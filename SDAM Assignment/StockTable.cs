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

namespace SDAM_Assignment
{
    public partial class StockTable : Form
    {
        private SqlConnection newSql = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True");

        public StockTable()
        {
            InitializeComponent();
        }

        private void StockTable_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBox = false;
                newSql.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM stockItemTable", newSql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                newSql.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
