using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockControl.Tests
{
    [TestClass]
    public class StockItemTests
    {
        public static string productCsv;
        public StockItemTests()
        {
            // Testing csv product
            productCsv = "T001,A test product,7,No";
        }

        [TestMethod]
        public void StockItemFromCSVTest()
        {
            // Expected item code: T001

            // Create stock item from StockItem class
            StockItem stockItem = new StockItem(productCsv);

            // Assert that item's code is T001
            Assert.AreEqual("T001", stockItem.ItemCode);
        }
    }
}
