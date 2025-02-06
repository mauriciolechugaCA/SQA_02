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
        // ProdID Test 1
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        // ProdID Test 2
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        // ProdID Test 3
        public void Test3()
        {
            Assert.Pass();
        }

        /// <summary>
        /// Test cases for ProductName
        /// </summary>
        [Test]
        // ProdName Test 1: Checks if the property returns the expected length.
        public void ValidateLengthName_ExpectedLengthName_True()
        {
            // Arrange
            string expectedName = "TestProductName";
            Product product = new Product(1000, expectedName, 500.0, 50);

            // Act
            bool result = product.ValidateLengthName();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // ProdName Test 2: Checks if the property returns an empty string
        public void ValidateEmptyName_ExpectedNameEmpty_True()
        {
            // Arrange
            string expectedName = "";
            Product product = new Product(1001, expectedName, 500.0, 50);

            // Act
            bool result = product.ValidateStandardName();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // ProdName Test 3: Checks if the property returns the expected name with special characters.
        public void ValidateSpecialCharactersName_ExpectedNameSpecialCharacters_True()
        {
            // Arrange
            string expectedName = "Special!@#$%^&*()_-+={}[]|:;'\"<>,.?/~`";
            Product product = new Product(1002, expectedName, 500.0, 50);

            // Act
            bool result = product.ValidateSpecialCharactersName();

            // Assert
            Assert.That(result, Is.True);
        }


        /// <summary>
        /// Test cases for ItemPrice
        /// </summary>
        [Test]
        // ItemPrice Test 1
        public void Test111()
        {
            Assert.Pass();
        }

        [Test]
        // ItemPrice Test 2
        public void Test112()
        {
            Assert.Pass();
        }

        [Test]
        // ItemPrice Test 3
        public void Test113()
        {
            Assert.Pass();
        }

        /// <summary>
        /// Test cases for StockAmount
        /// </summary>
        [Test]
        // StockAmount Test 1: Checks if the property returns the expected stock amount (Minimum value)
        public void ValidateStockAmount_expectedStock5_True()
        {
            // Arrange
            int expectedStock = 5;
            Product product = new Product(1003, "Test", 500.0, expectedStock);

            // Act
            bool result = product.ValidateStockAmount();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // StockAmount Test 2: Checks if the property returns the expected stock amount (Nominal) 
        public void ValidateStockAmount_expectedStock250000_True()
        {
            // Arrange
            int expectedStock = 250000;
            Product product = new Product(1004, "Test", 500.0, expectedStock);

            // Act
            bool result = product.ValidateStockAmount();

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        // StockAmount Test 3: Checks if the property returns the expected stock amount (maximum value)
        public void ValidateStockAmount_expectedStock500000_True()
        {
            // Arrange
            int expectedStock = 500000;
            Product product = new Product(1005, "Test", 500.0, expectedStock);

        // Act
            bool result = product.ValidateStockAmount();

        // Assert
        Assert.That(result, Is.True);
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