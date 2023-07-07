class Program
{
    static void Main()
    {

        List<double> numbers = new List<double> { 2.5, 7.5, 6.2, 82.6, 42, 46.2, 12.5 };

        Console.WriteLine("Insert the number for skip");
        int skipCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert the number for take");
        int takeCount = int.Parse(Console.ReadLine());

        IEnumerable<double> subset = numbers.Skip(skipCount).Take(takeCount);
        Console.WriteLine(subset);

        double sum = subset.Sum();
        double avg = subset.Average();
        int count = subset.Count();

        Console.WriteLine("Sum : " + sum);
        Console.WriteLine("Avg : " + avg);
        Console.WriteLine("Count items : " + count);

        Console.WriteLine("Subset values:");
        foreach (double value in subset)
        {
            Console.WriteLine(value);
        }

        Console.ReadLine();

    }
}
