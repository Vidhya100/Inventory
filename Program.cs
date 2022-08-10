namespace StocksInventory
{
    class Program
    {
        public static void Main(string[] args)
        {
           StockPortfolio stockPortfolio = new StockPortfolio();
            string filepath = ".\\..\\..\\..\\JSONDATA.json";

            Stocks inventory = stockPortfolio.ReadFromFile(filepath);

            //stockPortfolio.GetInventoryTotalValue();
            ////stockPortfolio.m_inventoryFactory.GetTextilePrice();
            //stockPortfolio.m_inventoryFactory.GetPaperPrice();
            //stockPortfolio.m_inventoryFactory.GetPackagingPrice();
            Console.WriteLine("Total Stocks value: " + stockPortfolio.GetInventoryTotalValue());

            Console.WriteLine("Total Textile stocks price: " + stockPortfolio.m_inventoryFactory.GetTextilePrice());
            Console.WriteLine("Total Paper stocks price: " + stockPortfolio.m_inventoryFactory.GetPaperPrice());
            Console.WriteLine("Total Packaging stocks price: " + stockPortfolio.m_inventoryFactory.GetPackagingPrice());



            //for (int i = 0; i < inventory.typesOfRice.Count; i++)
            //{
            //    Console.WriteLine(inventory.typesOfRice[i].name);
            //    Console.WriteLine(inventory.typesOfRice[i].weight);
            //    Console.WriteLine(inventory.typesOfRice[i].price);

            //    Console.WriteLine("=====================================");
            //}
        }
    }
}