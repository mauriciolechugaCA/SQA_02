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

        // Method to check if the ProdName is empty.
        public bool ValidateEmptyName()
        {
            if (ProdName == "")
            {
                return true;
            }
            return false;
        }

        // Method to check the length of ProdName.
        public bool ValidateLengthName()
        {
            if (ProdName.Length < 5 || ProdName.Length > 100)
            {
                return false;
            }
            return true;
        }

        // Method to check if the ProdName has a Special Character.
        public bool ValidateSpecialCharactersName()
        {
            if (ProdName.Contains("!") || ProdName.Contains("@") || ProdName.Contains("#") || ProdName.Contains("$") || ProdName.Contains("%") || ProdName.Contains("^") || ProdName.Contains("&") || ProdName.Contains("*") || ProdName.Contains("(") || ProdName.Contains(")") || ProdName.Contains("-") || ProdName.Contains("_") || ProdName.Contains("+") || ProdName.Contains("=") || ProdName.Contains("{") ||
                ProdName.Contains("}") || ProdName.Contains("[") || ProdName.Contains("]") || ProdName.Contains("|") || ProdName.Contains(":") || ProdName.Contains(";") || ProdName.Contains("'") || ProdName.Contains("\"") || ProdName.Contains("<") || ProdName.Contains(">") || ProdName.Contains(",") || ProdName.Contains(".") || ProdName.Contains("?") || ProdName.Contains("/") || ProdName.Contains("~") || ProdName.Contains("`"))
            {
                return true;
            }
            return false;
        }

        // Method to check if StockAmount is between 5 and 500000.
        public bool ValidateStockAmount()
        {
            if (StockAmount < 5 || StockAmount > 500000)
            {
                return false;
            }
            return true;
        }

        //Method to check the range of the ProdID
        public bool CheckProdIDRange()
        {
            if (ProdID >= 5 && ProdID <= 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to check the range of the ItemPrice
        public bool CheckItemPriceRange()
        {
            if (ItemPrice >= 5 && ItemPrice <= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
