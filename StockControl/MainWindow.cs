using System;
using System.Data;
using System.Windows.Forms;

namespace StockControl
{
    public partial class MainWindow : Form
    {
        private DataGridViewRow currentRow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Disable Auto Columns
            gridStocks.AutoGenerateColumns = false;

            // Initial Grid View Load
            LoadStocksView();
        }

        private void LoadStocksView()
        {
            // Create new table to assign stocks to
            DataTable stockDataTable = new DataTable();
            // Initialise DataTable rows
            DataColumn[] columns =
            {
                new DataColumn("ItemCode", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("CurrentCount", typeof(Int32)),
                new DataColumn("OnOrder", typeof(Boolean))
            };

            // Add columns to table
            stockDataTable.Columns.AddRange(columns);

            // Loop through items
            foreach (StockItem item in Program.stockItems)
            {
                // Add item to table as row
                stockDataTable.Rows.Add(item.GetDataRow(stockDataTable));
            }

            // Set grid view to table
            gridStocks.DataSource = stockDataTable;
        }

        private void UpdateSideControls()
        {
            // Update current row
            currentRow = gridStocks.CurrentRow;

            // Set all fields to current row
            txt_ItemCode.Text = currentRow.Cells[0].Value.ToString();
            txt_Description.Text = currentRow.Cells[1].Value.ToString();
            txt_CurrentCount.Text = currentRow.Cells[2].Value.ToString();
            box_OnOrder.Checked = Boolean.Parse(currentRow.Cells[3].Value.ToString());
        }

        private void GridStocks_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Update the side control panel
            UpdateSideControls();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            // Reload stocks
            Program.ReloadStocks();
            // Reload stock view
            LoadStocksView();

            MessageBox.Show("Stocks have been reloaded.");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bool saved;
            
            // Save all stocks to the default path
            saved = StockItems.SaveToCSV((DataTable) gridStocks.DataSource, Program.defaultStocksCSVPath);

            if (saved)
            {
                MessageBox.Show("Stocks have been saved.");
            }
        }

        private void Txt_CurrentCount_TextChanged(object sender, EventArgs e)
        {
            // Update current row
            currentRow = gridStocks.CurrentRow;
            // Set current count to the current count text box value
            currentRow.Cells[2].Value = txt_CurrentCount.Text;
        }
    }
}
