using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Классная работа");
            Console.Write("Ведите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Ведите день: ");
            int day = int.Parse(Console.ReadLine());
            if (year % 4 != 0 || year % 100 == 0)
            {
                if (day >= 1 & day <= 31)
                {
                    Console.WriteLine("Янаврь " + day);
                }
                if (day >= 32 & day <= 59)
                {
                    Console.WriteLine("Февраль " + (day - 31));
                }
                if (day >= 60 & day <= 90)
                {
                    Console.WriteLine("Март " + (day - 59));
                }
                if (day >= 91 & day <= 120)
                {
                    Console.WriteLine("Апрель " + (day - 90));
                }
                if (day >= 121 & day <= 151)
                {
                    Console.WriteLine("Май " + (day - 120));
                }
                if (day >= 152 & day <= 181)
                {
                    Console.WriteLine("Июнь " + (day - 151));
                }
                if (day >= 182 & day <= 212)
                {
                    Console.WriteLine("Июль " + (day - 181));
                }
                if (day >= 213 & day <= 243)
                {
                    Console.WriteLine("Август " + (day - 212));
                }
                if (day >= 244 & day <= 273)
                {
                    Console.WriteLine("Сентябрь " + (day - 243));
                }
                if (day >= 274 & day <= 304)
                {
                    Console.WriteLine("Октябрь " + (day - 273));
                }
                if (day >= 305 & day <= 334)
                {
                    Console.WriteLine("Ноябрь " + (day - 304));
                }
                if (day >= 335 & day <= 365)
                {
                    Console.WriteLine("Декбрь " + (day - 334));
                }
                if (day <= 0 || day >= 365)
                {
                    Console.WriteLine("Неправильное число");
                }
            }
            if ((year % 4 == 0 & year % 100 != 0) || (year % 400 == 0))
            {
                if (day >= 1 & day <= 31)
                {
                    Console.WriteLine("Янаврь " + day);
                }
                if (day >= 32 & day <= 60)
                {
                    Console.WriteLine("Февраль " + (day - 31));
                }
                if (day >= 61 & day <= 91)
                {
                    Console.WriteLine("Март " + (day - 60));
                }
                if (day >= 92 & day <= 121)
                {
                    Console.WriteLine("Апрель " + (day - 91));
                }
                if (day >= 122 & day <= 152)
                {
                    Console.WriteLine("Май " + (day - 121));
                }
                if (day >= 153 & day <= 182)
                {
                    Console.WriteLine("Июнь " + (day - 152));
                }
                if (day >= 183 & day <= 213)
                {
                    Console.WriteLine("Июль " + (day - 182));
                }
                if (day >= 214 & day <= 244)
                {
                    Console.WriteLine("Август " + (day - 213));
                }
                if (day >= 245 & day <= 274)
                {
                    Console.WriteLine("Сентябрь " + (day - 244));
                }
                if (day >= 275 & day <= 305)
                {
                    Console.WriteLine("Октябрь " + (day - 274));
                }
                if (day >= 306 & day <= 335)
                {
                    Console.WriteLine("Ноябрь " + (day - 305));
                }
                if (day >= 336 & day <= 366)
                {
                    Console.WriteLine("Декбрь " + (day - 335));
                }
                if (day <= 0 || day >= 366)
                {
                    Console.WriteLine("Неправильное число");
                }
            }

        }
    }
}
