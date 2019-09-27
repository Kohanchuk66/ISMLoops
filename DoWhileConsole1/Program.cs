using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0,d,r;
            do
            {
                Console.WriteLine("Введите целое число :");
                var P = Console.ReadLine();
                if (!int.TryParse(P, out r))
                {
                    Console.WriteLine("Не число");
                    Environment.Exit(0);
                }
                
                d = Convert.ToInt32(P);
                s += r;
            }
            while (d != 0);
            Console.WriteLine($"Сумма: {s}");
        }
    }
}
