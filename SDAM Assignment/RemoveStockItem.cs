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
    public partial class RemoveStockItem : Form
    {
        public RemoveStockItem()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            stockCodeRemInput.Clear();
            removeQuantityInput.Clear();
        }

        private void RemoveStockQty_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.setStock(Convert.ToInt32(stockCodeRemInput.Text), Convert.ToInt32(removeQuantityInput.Text));
                if (Convert.ToInt32(removeQuantityInput.Text) >= 0)
                {
                    stock.removeStockQty();
                }else
                {
                    MessageBox.Show("Quantity should be more than or equal to 0", "Quantity Not Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                stockCodeRemInput.Clear();
                removeQuantityInput.Clear();
            }
        }
    }
}
