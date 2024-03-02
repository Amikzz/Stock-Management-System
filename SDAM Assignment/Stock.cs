using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SDAM_Assignment
{
    internal class Stock
    {
        private int stockCode;
        private string stockName;
        private int stockQty;
        private static int entryId = 0;

        private SqlConnection newSql = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True");

        public Stock() { }

        public Stock(int stockCode, string stockName, int stockQty)
        {
            this.stockCode = stockCode;
            this.stockName = stockName;
            this.stockQty = stockQty;
        }

        public void setStock(int stockCode, int stockQty)
        {
            this.stockCode = stockCode;
            this.stockQty = stockQty;
        }

        //Add a new item to the database
        public void addNewStock() 
        {
            try
            {
                newSql.Open();
                string querry = "SELECT * FROM stockItemTable WHERE stockId= '" + stockCode + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, newSql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    stockItemAlreadyExistMessage();
                }
                else
                {
                    sqlCommandForAddNewItem();
                    entryForAddingNewStock();
                   
                }
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
        public void stockItemAlreadyExistMessage()
        {
            MessageBox.Show($"Item with Stock Code {stockCode} already exists", "Item Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void sqlCommandForAddNewItem()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO stockItemTable(stockId,stockName,stockQty)values('" + (Convert.ToInt16(stockCode)) + "','" + stockName + "','" + (Convert.ToInt16(stockQty)) + "')", newSql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New stock item successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void entryForAddingNewStock()
        {
            entryId++;
            string description = $"New stock item with stockcode {stockCode}, stock name {stockName} and stock quantity {stockQty} added";
            SqlCommand cmd = new SqlCommand("INSERT INTO transactionLogTable(entryId,date,description)values('" + Convert.ToInt16(entryId) + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) + "','" + description.ToString() + "')", newSql);
            cmd.ExecuteNonQuery();
        }

        //Add more stock quantity to an already existing stock item
        public void addStockQty()
        {
            try
            {
                newSql.Open();
                string querry = "SELECT * FROM stockItemTable WHERE stockId= '" + stockCode + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, newSql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    int totalStockQty = Convert.ToInt32(dataTable.Rows[0][2].ToString());
                    totalStockQty = totalStockQty + stockQty;
                    SqlCommand cmd = new SqlCommand("UPDATE stockItemTable SET stockQty= '" + totalStockQty + "' WHERE stockId = '" + stockCode+ "'", newSql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"New Stock quantity of {stockQty} added to stock code {stockCode} successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entryForAddingStockQty();
                }
                else
                {
                    stockItemNotExistMessage();
                }
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
        public void stockItemNotExistMessage()
        {
            MessageBox.Show($"Stock item with stock code {stockCode} doesn't exist", "Stock doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void entryForAddingStockQty()
        {
            entryId++;
            string description = $"Quantity of {stockQty} added to the stock item with stock code {stockCode}";
            SqlCommand cmd = new SqlCommand("INSERT INTO transactionLogTable(entryId,date,description)values('" + entryId + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) + "','" + description + "')", newSql);
            cmd.ExecuteNonQuery();
        }

        //Remove stock quantity from the database
        public void removeStockQty()
        {
            try
            {
                newSql.Open();
                string querry = "SELECT * FROM stockItemTable WHERE stockId= '" + stockCode + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, newSql);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    int totalStockQty = Convert.ToInt32(dataTable.Rows[0][2].ToString());
                    totalStockQty = totalStockQty - Convert.ToInt32(stockQty);
                    if (totalStockQty > 0)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE stockItemTable SET stockQty= '" + totalStockQty + "' WHERE stockId = '" + stockCode + "'", newSql);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Stock quantity of {stockQty} removed from stock item {stockCode} successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        entryForRemovingStockQty();
                    }
                    else
                    {
                        stockItemDeleteQuerry();
                    }
                }
                else
                {
                    MessageBox.Show($"Stock Item with stock code {stockCode} doesn't exist", "Stock doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
        public void stockItemDeleteQuerry()
        {
            if (MessageBox.Show($"Enough stock quantity doesn't exist. Do you want to delete this stock item with stock code {stockCode}?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM stockItemTable WHERE stockId= '" + stockCode + "'", newSql);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Stock item {stockCode} deleted successfully", "Successfully Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entryForDeletingStockItem();
            }
            else
            {
                MessageBox.Show($"No changes were made to the item with stock code {stockCode}", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void entryForRemovingStockQty()
        {
            entryId++;
            string description = $"Quantity of {stockQty} removed from stock item with stock code {stockCode}";
            SqlCommand cmd = new SqlCommand("INSERT INTO transactionLogTable(entryId,date,description)values('" + entryId + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) + "','" + description + "')", newSql);
            cmd.ExecuteNonQuery();
        }
        public void entryForDeletingStockItem()
        {
            entryId++;
            string description = $"Stock item with stock code {stockCode} deleted";
            SqlCommand cmd = new SqlCommand("INSERT INTO transactionLogTable(entryId,date,description)values('" + entryId + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) + "','" + description + "')", newSql);
            cmd.ExecuteNonQuery();
        }
    }
}