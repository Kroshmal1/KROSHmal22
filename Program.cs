using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] masses = { 68.4, 23.5, 71.8, 29.1, 212.3 };
            double totalMass = 0;
            foreach (double mass in masses) 
            {
                totalMass += mass;
            }
            Console.WriteLine($"Общая масса груза: {totalMass} кг");
        }
    }
}
