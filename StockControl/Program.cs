using System;
using System.Windows.Forms;
using System.Configuration;

namespace StockControl
{
    static class Program
    {
        public static StockItems stockItems;
        public static readonly string defaultStocksCSVPath = ConfigurationManager.AppSettings["stocklist"];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initial stocks load
            ReloadStocks();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static void ReloadStocks()
        {
           // Load stocks from CSV file    
           stockItems = StockItems.LoadFromCSVFile(defaultStocksCSVPath);
        }
    }
}
