using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{
    public static List<int> findPath(int n, int m)
    {
        List<int> path = new List<int>();
        path.Add(1); int currnum = 1;
        do
        {
            for (int i = 1; i < m; i++)
            {
                if (currnum < n) currnum++;
                else currnum = 1;
            }
            if (currnum == 1) break;
            path.Add(currnum);
        } while (true);

        return path;
    }

    public static void Main(string[] args)
    {
        //TASK1
        if (args.Length != 2) {
            Console.WriteLine("Enter n and m !");
            Environment.Exit(1);
        }

        List<int> result = findPath(int.Parse(args[0]), int.Parse(args[1]));

        foreach (int num in result) {
            Console.Write(num);
        }
        Console.WriteLine();
        
    }
}