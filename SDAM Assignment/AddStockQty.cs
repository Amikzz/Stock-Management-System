using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_Assignment
{
    public partial class AddStockQty : Form
    {
        public AddStockQty()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        { }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.setStock(Convert.ToInt32(stockCodeExistInput.Text), Convert.ToInt32(quantityAddInput.Text));
                if (Convert.ToInt32(quantityAddInput.Text) > 0)
                {
                    stock.addStockQty();
                }
                else
                {
                    MessageBox.Show("Quantity should be more than 0", "Quantity Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                stockCodeExistInput.Clear();
                quantityAddInput.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            stockCodeExistInput.Clear();
            quantityAddInput.Clear();
        }

        private void AddStockQty_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
