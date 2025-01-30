namespace SQA_02
{
    public class Product
    {
        public int ProdID { get; set; } // Fernando
        public string ProdName { get; set; } // Matheus
        public double ItemPrice { get; set; } // Fernando
        public int StockAmount { get; set; } // Matheus

        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public int IncreaseStock(int amount) // Mauricio
        {
            StockAmount += amount;
            return StockAmount;
        }

        public int DecreaseStock(int amount) // Mauricio
        {
            StockAmount -= amount;
            return StockAmount;
        }
    }
}
