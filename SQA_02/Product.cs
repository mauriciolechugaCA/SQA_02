namespace SQA_02
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public double ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int prodID, string prodName, double itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        public int IncreaseStock(int amount)
        {
            StockAmount += amount;
            return StockAmount;
        }

        public int DecreaseStock(int amount)
        {
            StockAmount -= amount;
            return StockAmount;
        }
    }
}
