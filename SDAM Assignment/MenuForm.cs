using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_Assignment
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        AddNewItem addNewItem = new AddNewItem();
        AddStockQty addStockQty = new AddStockQty();
        RemoveStockItem removeStockQty = new RemoveStockItem();
        StockTable stockTable = new StockTable();
        TransactionLog transactionLog = new TransactionLog();

        private void addNewStockButton_Click(object sender, EventArgs e)
        {
            addNewItem.Show();
        }

        private void addQtyButton_Click(object sender, EventArgs e)
        {
            addStockQty.Show();
        }

        private void removeStockButton_Click(object sender, EventArgs e)
        {
            removeStockQty.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void stockLevelButton_Click(object sender, EventArgs e)
        {
            stockTable.Show();
        }

        private void viewTransactionButton_Click(object sender, EventArgs e)
        {
            transactionLog.Show();
        }
    }
}
