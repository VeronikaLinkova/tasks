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
        
    }
}
