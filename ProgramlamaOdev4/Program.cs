using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaOdev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int disdongu = 0, icdongu = 0;
            for (int i = 0; i < 25; i++)
            {
                disdongu++;
                for (int j = 0; j < 5; j++)
                    icdongu++;
            }
            Console.WriteLine("Dış Döngü: " + disdongu);
            Console.WriteLine("İç Döngü: " + icdongu);
            Console.ReadLine();
        }
    }
}
