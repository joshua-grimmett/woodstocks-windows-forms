using System;
using System.Data;
using System.Xml;

namespace StockControl
{
    public class StockItem
    {
        public string ItemCode { get; }
        public string Description { get; }
        public int CurrentCount { get; set; }
        public bool OnOrder { get; }

        public StockItem(string csvLine)
        {
            // Parse CSV to array
            string[] line = csvLine.Split(',');
            // Columns count should not exceed 4
            if (line.Length > 4)
            {
                throw new Exception("Invalid CSV line");
            }

            // Parse line to columns
            ItemCode = line[0];
            Description = line[1];
            CurrentCount = Int32.Parse(line[2]);

            // Parse Yes/No
            string onOrder = line[3].ToLower();
            if (onOrder == "true" || onOrder == "yes")
            {
                OnOrder = true;
            }
            else if (onOrder == "false" || onOrder == "no")
            {
                OnOrder = false;
            }
            else
            {
                throw new InvalidCastException();
            }
        }

        public DataRow GetDataRow(DataTable table)
        {
            // Initialise new row variable
            DataRow row;
            // Create row from given table
            row = table.NewRow();

            // Assign column values
            row["ItemCode"] = this.ItemCode;
            row["Description"] = this.Description;
            row["CurrentCount"] = this.CurrentCount;
            row["OnOrder"] = this.OnOrder;

            // Return the new row
            return row;
        }
    }
}
