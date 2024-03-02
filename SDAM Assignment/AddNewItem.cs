using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_Assignment
{
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //stock class addNewStock method stores data in the database
                Stock stock = new Stock(Convert.ToInt32(stockCodeInput.Text), stockNameInput.Text.ToString(), Convert.ToInt32(enterQuanityInput.Text));
                if (Convert.ToInt32(enterQuanityInput.Text) > 0)
                {
                    stock.addNewStock();
                } else
                {
                    MessageBox.Show("Stock Quantity should be more than 0", "Quantity Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Hide();
                stockCodeInput.Text = null; stockNameInput.Text = null; enterQuanityInput.Text = null;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            stockCodeInput.Clear();
            enterQuanityInput.Clear();
            stockNameInput.Clear();
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
