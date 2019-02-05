using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_про_ворон
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ворон:");

            int lastNumber;
            string val;
            Int64 val1 = 0;
            while (val1 != (-5))
            {
                val = Console.ReadLine();
                try
                {
                    val1 = Convert.ToInt64(val);
                    lastNumber = Convert.ToInt32(val1 % 10);
                    if (val1 < 0)
                    {
                        Console.WriteLine("Введите число больше нуля");
                    }
                    else
                    {
                        if ((lastNumber >= 5 && lastNumber <= 10) || (val1 >= 11 && val1 <= 14))
                        {
                            Console.WriteLine($"На ветке сиделo {val1} ворон");
                        }
                        else
                        {
                            switch (lastNumber)
                            {
                                case 0:
                                    Console.WriteLine($"На ветке сиделo {val1} ворон");
                                    break;
                                case 1:
                                    Console.WriteLine($"На ветке сидела {val1} ворона");
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                    Console.WriteLine($"На ветке сидело {val1} вороны");
                                    break;
                                default:
                                    Console.WriteLine("Вы нажали неведомую хрень");
                                    break;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }              
                                                                                                       
            }           

        }
    }
}
