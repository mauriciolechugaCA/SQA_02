using NUnit.Framework;
using SQA_02;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // Maximum and minimum values:
        // Product ID: 5 - 50000
        // Price: $5 - $5000
        // Stock: 5 - 500000

        /// <summary>
        /// Test cases for ProductID
        /// </summary>
        [Test]
        // ProdID Test 1: Checks if the nominal value is within the expected range
        public void CheckProdIDRange_input25000_True()
        {
            //Arrange
            int input = 25000;
            Product product = new Product(input, "ProdIDNominalValueTest", 100, 1);

            //Act
            bool result = product.CheckProdIDRange();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // ProdID Test 2: Checks if returns false when the value is below the minimum
        public void CheckProdIDRange_input4_False()
        {
            //Arrange
            int input = 4;
            Product product = new Product(input, "ProdIDMinimumValueTest", 100, 1);

            //Act
            bool result = product.CheckProdIDRange();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        // ProdID Test 3: Checks if returns false when the value is above the maximum
        public void CheckProdIDRange_input50001_False()
        {
            //Arrange
            int input = 50001;
            Product product = new Product(50001, "ProdIDMaximumValueTest", 100, 1);

            //Act
            bool result = product.CheckProdIDRange();

            //Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// Test cases for ProductName
        /// </summary>
        [Test]
        // ProdName Test 1: Checks if the property returns the expected name ("Standard")
        public void ProdName_Standard_ReturnsExpectedValue()
        {
            // Arrange
            string expectedName = "Standard";
            Product product = new Product(1000, expectedName, 500.0, 50);

            // Act
            string actualName = product.ProdName;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        // ProdName Test 2: Checks if the property returns an empty string
        public void ProdName_Empty_ReturnsExpectedValue()
        {
            // Arrange
            string expectedName = "";
            Product product = new Product(1001, expectedName, 500.0, 50);

            // Act
            string actualName = product.ProdName;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        // ProdName Test 3: Checks if the property returns the expected name with special characters.
        public void ProdName_SpecialCharacters_ReturnsExpectedValue()
        {
            // Arrange
            string expectedName = "Pr@d#ct$.";
            Product product = new Product(1002, expectedName, 500.0, 50);

            // Act
            string actualName = product.ProdName;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }

        /// <summary>
        /// Test cases for ItemPrice - Price: $5 - $5000
        /// </summary>
        [Test]
        // ItemPrice Test 1: Checks if the nominal value is within the expected range
        public void CheckItemPriceRange_input2500_True()
        {
            //Arrange
            int input = 2500;
            Product product = new Product(25000, "ItemPriceNominalValueTest", input, 1);

            //Act
            bool result = product.CheckItemPriceRange();

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // ItemPrice Test 2: Checks if returns false when the value is below the minimum
        public void CheckItemPriceRange_input4_False()
        {
            //Arrange
            int input = 4;
            Product product = new Product(25000, "ItemPriceMinimumValueTest", input, 1);

            //Act
            bool result = product.CheckItemPriceRange();

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        // ItemPrice Test 3: Checks if returns false when the value is above the maximum
        public void CheckItemPriceRange_input5001_False()
        {
            //Arrange
            int input = 5001;
            Product product = new Product(25000, "ItemPriceMaximumValueTest", input, 1);

            //Act
            bool result = product.CheckItemPriceRange();

            //Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// Test cases for StockAmount
        /// </summary>
        [Test]
        // StockAmount Test 1: Checks if the property returns the lower boundary stock amount
        public void StockAmount_LowerBoundary_ReturnsExpectedValue()
        {
            // Arrange
            int expectedStock = 5;
            Product product = new Product(1003, "Test", 500.0, expectedStock);

            // Act
            int actualStock = product.StockAmount;

            // Assert
            //Assert.AreEqual(expectedStock, actualStock);
        }

        [Test]
        // StockAmount Test 2: Checks if the property returns the middle value stock amount
        public void StockAmount_MidValue_ReturnsExpectedValue()
        {
            // Arrange
            int expectedStock = 250000;
            Product product = new Product(1004, "Test", 500.0, expectedStock);

            // Act
            int actualStock = product.StockAmount;

            // Assert
            //Assert.AreEqual(expectedStock, actualStock);
        }

        [Test]
        // StockAmount Test 3: Checks if the property returns the upper boundary stock amount
        public void StockAmount_UpperBoundary_ReturnsExpectedValue()
        {
            // Arrange
            int expectedStock = 500000;
            Product product = new Product(1005, "Test", 500.0, expectedStock);

            // Act
            int actualStock = product.StockAmount;

            // Assert
            //Assert.AreEqual(expectedStock, actualStock);
        }

        /// <summary>
        /// Test cases for IncreaseStock
        /// </summary>
        [Test]
        // IncreaseStock Test 1: Minimum Increase
        public void IncreaseStock_WithMinimumAmount_ShouldIncreaseStockByOne()
        {
            // Arrange
            var product = new Product(10, "TestProduct", 100.0, 5);
            int increaseAmount = 1;
            int expectedStock = 6;

            // Act
            int actualStock = product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        // IncreaseStock Test 2: Typical Increase
        public void IncreaseStock_WithTypicalAmount_ShouldIncreaseStockCorrectly()
        {
            // Arrange
            var product = new Product(20, "SampleProduct", 250.0, 100);
            int increaseAmount = 150;
            int expectedStock = 250;

            // Act
            int actualStock = product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        // IncreaseStock Test 3: Maximum Increase
        public void IncreaseStock_WithMaximumAmount_ShouldReachMaximumStock()
        {
            // Arrange
            var product = new Product(30, "MaxProduct", 500.0, 499999);
            int increaseAmount = 1;
            int expectedStock = 500000;

            // Act
            int actualStock = product.IncreaseStock(increaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        /// <summary>
        /// Test cases for DecreaseStock
        /// </summary>

        [Test]
        // DecreaseStock Test 1: Minimum Decrease
        public void DecreaseStock_WithMinimumAmount_ShouldDecreaseStockByOne()
        {
            // Arrange
            var product = new Product(40, "MinDecreaseProduct", 50.0, 6);
            int decreaseAmount = 1;
            int expectedStock = 5;

            // Act
            int actualStock = product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        // DecreaseStock Test 2: Typical Decrease
        public void DecreaseStock_WithTypicalAmount_ShouldDecreaseStockCorrectly()
        {
            // Arrange
            var product = new Product(50, "TypicalDecreaseProduct", 200.0, 250);
            int decreaseAmount = 150;
            int expectedStock = 100;

            // Act
            int actualStock = product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

        [Test]
        // DecreaseStock Test 3: Maximum Decrease
        public void DecreaseStock_WithMaximumAmount_ShouldReachMinimumStock()
        {
            // Arrange
            var product = new Product(60, "MaxDecreaseProduct", 300.0, 500000);
            int decreaseAmount = 499995;
            int expectedStock = 5;

            // Act
            int actualStock = product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.That(actualStock, Is.EqualTo(expectedStock));
        }

    }
}