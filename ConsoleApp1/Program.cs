namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of small carpets");
            int smallCarpets=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpets");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            int cost=(smallCarpets*25)+(largeCarpets*35);
            double tax = cost *0.06;
            double totalEstimate = tax + cost;

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets: {smallCarpets} <--");
            Console.WriteLine($"Number of large carpets: {largeCarpets} <--");
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${totalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
