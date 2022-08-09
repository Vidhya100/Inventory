namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();

            string filepath = "E:\\c#\\Inventory\\InventoryManagement\\InventoryManagement\\JSONDATA.json";
            Rice data = fetchInventoryDetails.ReadDataFromFile(filepath);

            //for Rice
            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine(data.typesOfRice[i].weight);

                int total = data.typesOfRice[i].price * data.typesOfRice[i].weight;
                Console.WriteLine("The price of "+ data.typesOfRice[i].name + "is: "+ total);

                Console.WriteLine("----------------------------------------");
            }

            //for Pulses
            for(int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].price);
                Console.WriteLine(data.typesOfPulses[i].weight);

                int total = data.typesOfPulses[i].price * data.typesOfPulses[i].weight;
                Console.WriteLine("The price of " + data.typesOfPulses[i].name + "is: " + total);

                Console.WriteLine("----------------------------------------");
            }

            //for wheats
            for (int i = 0; i < data.typesOfWheats.Count; i++)
            {
                Console.WriteLine(data.typesOfWheats[i].name);
                Console.WriteLine(data.typesOfWheats[i].price);
                Console.WriteLine(data.typesOfWheats[i].weight);

                int total = data.typesOfWheats[i].price * data.typesOfWheats[i].weight;
                Console.WriteLine("The price of " + data.typesOfWheats[i].name + "is: " + total);

                Console.WriteLine("----------------------------------------");
            }
        }
    }
}