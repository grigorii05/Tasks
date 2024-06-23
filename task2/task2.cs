using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //TASK2
        if (args.Length != 2)
        {
            Console.WriteLine("Enter circle and dot !");
            Environment.Exit(1);
        }
        float a, b; // Координаты центра круга
        float R; // Радиус круга

        using (StreamReader circle = new StreamReader(args[0]))
        {
            string[] circleCoords = circle.ReadLine().Split();
            a = float.Parse(circleCoords[0]);
            b = float.Parse(circleCoords[1]);
            R = float.Parse(circle.ReadLine());
        }

        using (StreamReader dot = new StreamReader(args[1]))
        {
            float x, y;
            while (!dot.EndOfStream)
            {
                string[] dotCoords = dot.ReadLine().Split();
                x = float.Parse(dotCoords[0]);
                y = float.Parse(dotCoords[1]);

                if ((x - a) * (x - a) + (y - b) * (y - b) == R * R) Console.WriteLine(0);
                if ((x - a) * (x - a) + (y - b) * (y - b) < R * R) Console.WriteLine(1);
                if ((x - a) * (x - a) + (y - b) * (y - b) > R * R) Console.WriteLine(2);
            }
        }
    }
}