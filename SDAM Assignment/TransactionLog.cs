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
    public partial class TransactionLog : Form
    {
        public TransactionLog()
        {
            InitializeComponent();
        }

        private SqlConnection newSql = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True");

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                ControlBox = false;
                newSql.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM transactionLogTable", newSql);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
