using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Enter argument !");
            Environment.Exit(1);
        }
        List<int> nums = new List<int>();
        int num;
        using (StreamReader numbers = new StreamReader(args[0]))
        {
            string line;
            while ((line = numbers.ReadLine()) != null)
            {
                if (Int32.TryParse(line, out num))
                {
                    nums.Add(num);
                }
            }
        }

        int average = 0;
        foreach (int n in nums)
        {
            average += n;
        }
        average = average / nums.Count;

        int moves = 0;
        foreach (int n in nums)
        {
            moves += Math.Abs(n - average);
        }

        Console.WriteLine("Минимальное количество ходов: " + moves);
    }
}