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
            double quiz_1, quiz_2, last;

            Console.Write("1. Sınav notunuz: ");
            quiz_1 = double.Parse(Console.ReadLine());

            Console.Write("2. Sınav notunuz: ");
            quiz_2 = double.Parse(Console.ReadLine());

            last = (quiz_1 + quiz_2) / 2;

            if (last > 0 && last <= 100)
            {
                if (last < 50)
                {
                    Console.Clear();
                    Console.WriteLine("Notunuz " + last + " olduğu için kaldınız! :(");
                }
                else if (last >= 50)
                {
                    Console.Clear();
                    Console.WriteLine("Notunuz " + last + " olduğu için geçtiniz! ☻");
                }
            }
            Console.ReadKey();
        }
    }
}
