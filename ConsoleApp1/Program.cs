namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [1, 2, 3, 4, -2, 0, 7];
            //List<int> numbers = [];

            bool isQuit = false;
            while (!isQuit)
            {
                Console.WriteLine("Menu Options");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C -clear the list");
                Console.WriteLine("Q - Quit");

                string choice = Console.ReadLine().ToLower();
                if (choice != "p" && choice != "q" && choice != "a" && choice != "m" && choice != "s" && choice != "l"&& choice!="c")
                {
                    Console.WriteLine("Unknown selection, please try again");
                }
                switch (choice)
                {
                    case "p":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                            break;
                        }
                        Console.Write("[");
                        foreach (int num in numbers)
                        {
                            Console.Write($" {num} ");
                        }
                        Console.WriteLine("]");
                        break;
                    case "a":
                        Console.WriteLine("enter an intger number : ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine($"The number {number} is already in the list. Duplicates are not allowed.");
                        }
                        else
                        {
                            numbers.Add(number);
                            Console.WriteLine($"{number} added");
                        }
                        break;
                    case "m":
                        if (numbers.Count == 0) Console.WriteLine("Unable to calculate the mean - no data");
                        else Console.WriteLine($" the average of the list: {CalculateAverage(numbers)}");

                        break;
                    case "s":
                        if (numbers.Count == 0) Console.WriteLine("Unable to determine the smallest number - list is empty");
                        else Console.WriteLine($"The smallest number is {CalculateSmallestNumber(numbers)}");
                        break;
                    case "l":
                        if (numbers.Count == 0) Console.WriteLine("Unable to determine the largest  number - list is empty");
                        else Console.WriteLine($"The largest  number is {CalculateLargesttNumber(numbers)}");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isQuit= true;
                        break;
                    case "c":
                        numbers.Clear();
                        Console.WriteLine("The list has been cleared. It is now empty.");
                        break;


                }
            }
        }
        static double CalculateAverage(List<int> numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double average = sum / (numbers.Count);
            return average;
        }
        static int CalculateSmallestNumber(List<int> numbers)
        {
            int smallest = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
                else
                {
                    continue;
                }
            }
            return smallest;
        }
        static int CalculateLargesttNumber(List<int> numbers)
        {
            int largest = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
                else
                {
                    continue;
                }
            }
            return largest;
        }
    }
}
