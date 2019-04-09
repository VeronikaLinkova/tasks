using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка_от_Егора
{
    class Program
    {
        static void Main(string[] args)
        {
            Example Ololo = new Example();
            int a = Ololo.Sum(-100,1, 9);
            Console.WriteLine(a);
            Console.ReadKey();

           int[] mas = Ololo.Age(10, 6);
           foreach (int elem in mas)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();

            Console.WriteLine(Ololo.Fahrenheit(10));
            Console.WriteLine(Ololo.Kelvin(-100));
            Console.ReadKey();
            Console.WriteLine(Ololo.Val());
            Console.ReadKey();
        }

    }
}
