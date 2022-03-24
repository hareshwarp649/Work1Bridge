using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, i;
            float G = 0;
            Console.WriteLine("Enter Number");

            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < k; i++)
            {
                //  Console.Write("1/")
                G += 1 / (float)i;
            }
            Console.WriteLine("Harmonic Number :" + G);
        }
    }
}
