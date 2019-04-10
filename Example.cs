using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Домашка_от_Егора
{
    public class Example
    {
        //задание 1
        public int Sum(int x, int y, int z)
        {
            int t = x * y + 37;
            if (t>0)
            {
                z = 2 * z;
                int rez = 7 * x + y;
                return rez;
            }
            else
            {
                if (x!=0)
                {
                    z = z / 2;
                }
                else
                {
                    z = z / 5;
                }
                int rez = 5 * y-x;
                return rez;               
            }            
        }

        //задание 2
        public int[] Age(int a, int b)
        {
            
            int averageAge = (a + b) / 2;
            int deviation1 = Math.Abs(a - averageAge);
            int deviation2 = Math.Abs(b - averageAge);
            int[] info = new int[3] {averageAge, deviation1, deviation2};
            return info;
        }
        //задание 3
        public double Fahrenheit(double cel)
        {            
            double far = (1.8 * cel)+32;
            return far;
        }

        public double Kelvin(double a)
        {
            double b = a+273.15;
            return b;            
        }

        //задание 4
        public int Val()
        {
            int rez = (564 % 10) * 100 + (564 / 100) + (((564 / 10) % 10)) * 10;
            return rez;
        }
        
         //задание 5
        public void krugVKvadrate(double skv, double skr)
        {
            //d - диаметр круга
            //a - сторона квадрата
            // p - число пи
            // d_kv - диаметр квадрата
            double a = 0;
            double p = 3.1415926535897931;
            double d_kv = Math.Sqrt(2 * (a * a));
            a = Math.Sqrt(skv);
            double d = Math.Sqrt((4 * skr) / p);
            if (d <= a)
            {
                Console.WriteLine("Круг помещается в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не помещается в квадрате");
            }


            if (d_kv <= d)
            {
                Console.WriteLine("Квадрат помещается в круг");
            }
            else
            {
                Console.WriteLine("Квадрат не помещается в круг");
            }
        }     
        
    }
}
