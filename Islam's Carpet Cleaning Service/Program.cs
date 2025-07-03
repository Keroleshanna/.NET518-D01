namespace Islam_s_Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float tax = 6;

            Console.WriteLine("Hello and welcome to Islam's Carpet Cleaning Service");

            Console.WriteLine("Estimate for carpet cleaning service\r\n");
            Console.WriteLine("==========================================");

            Console.Write("Number of small carpets: ");
            _ = int.TryParse(Console.ReadLine(), out int numberOfSmallCarpets);

            Console.Write("Number of large carpets: ");
            _ = int.TryParse(Console.ReadLine(), out int numberOfLargeCarpets);

            Console.WriteLine("\nPrice per small carpets: $25");
            Console.WriteLine("Price per Large carpets: $35");

            int totalCost = (numberOfSmallCarpets * 25) + (numberOfLargeCarpets * 35);
            Console.WriteLine($"Tottal Cost: ${totalCost}");


            float totalTax = (totalCost * tax) / 100;
            Console.WriteLine($"Tax: ${totalTax}");

            Console.WriteLine("==============================");
            Console.WriteLine($"Total estimate: ${totalCost + totalTax}");
            Console.WriteLine("This estimate is valid for 30 days\r\n");
        }
    }
}
