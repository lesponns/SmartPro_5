using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize, final, last, vlast, flast;

            q1:
            Console.Clear();
            Console.Write("1. Sınav notunuz: ");
            vize = double.Parse(Console.ReadLine());
            if (vize < 0 || vize > 100) { goto q1; }

            q2:
            Console.Clear();
            Console.Write("2. Sınav notunuz: ");
            final = double.Parse(Console.ReadLine());
            if (final < 0 || final > 100) { goto q2; }

            vlast = ((vize *40) / 100);
            flast = ((final *60) / 100);

            last = vlast + flast;

            if (last > 0 && last <= 100)
            {
                if (last < 50)
                {
                    Console.Clear();
                    Console.WriteLine("Notunuz " + last + " olduğu için kaldınız!");
                }
                else if (last >= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Notunuz " + last + " olduğu için geçtiniz!");
                }
            }
            Console.ReadKey();
        }
    }
}
