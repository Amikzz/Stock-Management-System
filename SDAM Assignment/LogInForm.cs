using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SDAM_Assignment
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        //Creates the SQL Connection
        private SqlConnection newSql = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True");

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameInput.Text;
            password = passwdInput.Text;
            try
            {
                String querry = "SELECT * FROM userTable WHERE username = '" + usernameInput.Text + "' AND password = '" + passwdInput.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, newSql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    username = usernameInput.Text;
                    password = passwdInput.Text;
                    MessageBox.Show("Log in Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid log in details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameInput.Clear();
                    passwdInput.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                newSql.Close(); 
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
