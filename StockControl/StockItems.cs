using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace StockControl
{
    class StockItems
    {
        private readonly List<StockItem> _stocks;

        public StockItems()
        {
            // Initialise stocks list
            _stocks = new List<StockItem>();
        }

        public static StockItems LoadFromCSVFile(string path)
        {
            // Confirm file exists
            if (!File.Exists(path))
            {  
                throw new FileNotFoundException(path);
            }

            // Instantiate stock items
            StockItems stockItems = new StockItems();

            // Load lines from file
            string[] lines = File.ReadAllLines(path);
            
            // Loop lines to create stock
            foreach (string line in lines)
            {
                // First line of CSV is column names
                if (lines[0] == line) continue;

                // Create new stock item from line string
                StockItem item = new StockItem(line);
                // Add new item to stock list
                stockItems.AddStockItem(item);
            }

            // Return object
            return stockItems;
        }

        public void AddStockItem(StockItem item)
        {
            // Add item to stocks
            this._stocks.Add(item);
        }

        public static bool SaveToCSV(DataTable table, string path)
        {
            // Inisialise new file string
            string newFile = $"{table.Columns[0].ColumnName},{table.Columns[1].ColumnName}," +
                $"{table.Columns[2].ColumnName},{table.Columns[3].ColumnName}\n";

            // Loop through existing rows
            foreach(DataRow row in table.Rows)
            {
                // Parse true/false to Yes/No
                string onOrder;
                if(Boolean.Parse(row["OnOrder"].ToString()) == true)
                {
                    onOrder = "Yes";
                }
                else
                {
                    onOrder = "No";
                }
                // Add CSV line to file
                newFile += $"{row["ItemCode"]},{row["Description"]},{row["CurrentCount"]},{onOrder}\n"; 
            }

            try
            {
                // Write new text to the file
                File.WriteAllText(path, newFile);
                return true;
            }
            catch
            {
                MessageBox.Show("Unauthorized access. Could not write to: " + path);
                return false;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _stocks.GetEnumerator();
        } 
    }
}
