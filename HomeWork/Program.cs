using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork
{
    enum Week
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    enum Cards
    {
        Шестерка = 6,
        Семерка = 7,
        Восьмерка = 8,
        Девятка = 9,
        Десятка = 10,
        Валет = 11,
        Дама = 12,
        Король = 13,
        Туз = 14
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            //////////////////////////////////////////////////////////////////////
            
            Console.WriteLine("Задача 1");
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите d: ");
            int d = int.Parse(Console.ReadLine());
            if ((a - d >= 2) & (b - d >= 2))
            {
                Console.WriteLine("Сможет");
            }
            else
            {
                Console.WriteLine("Не сможет");
            }

            //////////////////////////////////////////////////////

            Console.WriteLine("Задача 2");
            Console.Write("Введите число n от 1 до 9: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 & n <= 9)
            {
                Console.WriteLine(n + " x 1 = " + (n * 1));
                Console.WriteLine(n + " x 2 = " + (n * 2));
                Console.WriteLine(n + " x 3 = " + (n * 3));
                Console.WriteLine(n + " x 4 = " + (n * 4));
                Console.WriteLine(n + " x 5 = " + (n * 5));
                Console.WriteLine(n + " x 6 = " + (n * 6));
                Console.WriteLine(n + " x 7 = " + (n * 7));
                Console.WriteLine(n + " x 8 = " + (n * 8));
                Console.WriteLine(n + " x 9 = " + (n * 9));
            }

            ///////////////////////////////////////////////////////////

            Console.WriteLine("Задача 3");
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 15 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("Бэнг");
                }
                else
                {
                    if (x % 5 == 0)
                    {
                        Console.WriteLine("Бум");
                    }
                    else
                    {
                        Console.WriteLine("Мимо");
                    }
                }
            }

            ///////////////////////////////////////////////////////////

            Console.WriteLine("Задача 4");
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string s1 = s.ToUpper();
            if (s == s1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            /////////////////////////////////////////////////////////////////////

            Console.WriteLine("Задача 5");
            Console.Write("Введите целое положительное число: ");
            int x5 = int.Parse(Console.ReadLine());
            int nomer = 1;
            if (x5 > 0)
            {
                while (x5 > 0)
                {
                    if (x5 == 1)
                    {
                        Console.WriteLine(nomer + " овца...");
                        x5 -= 1;
                        nomer += 1;
                    }
                    else
                    {
                        Console.Write(nomer + " овца...");
                        x5 -= 1;
                        nomer += 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Неправильное число");
            }

            ///////////////////////////////////////////////////////////////////////////////////

            Console.Write("Задача 6");
            try
            {
                Console.Write("Введи количество символов: ");
                int x6 = int.Parse(Console.ReadLine());
                List<int> numbers6 = new List<int>();
                int i = 0;
                while (i != x6)
                {
                    Console.WriteLine("Введи число: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers6.Add(number);
                    i++;
                }
                int j = 0;
                double summa = 0;
                while (numbers6[j] >= 0)
                {
                    summa += (double)numbers6[j];
                    j++;
                }
                double average = (summa / ((double)(j)));
                Console.WriteLine(average);

            }
            catch
            {
                Console.WriteLine("В цонце должно быть отрицательное число");
            }

            //////////////////////////////////////////////////////////////////

            Console.Write("Задача 7");
            Console.Write("Введите число от 6 до 14: ");
            int cardnumber = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Enum.GetName(typeof(Cards), cardnumber));
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

            //////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Задача 8");
            string[] s8 = { "Hello kitty", "Rwertwertwer", "Barbie doll", "Barbie doll", "wewer", "Hello kitty", "Barbie doll" };
            int dolls = 0;
            foreach (string s81 in s8)
            {
                if (s81 == "Hello kitty" || s81 == "Barbie doll")
                {
                    dolls += 1;
                }
            }
            Console.WriteLine("Всего кукол: " + dolls);

            /////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Задача 9");
            Console.WriteLine("Введите число дня недели от 1 до 7");
            int x9 = int.Parse(Console.ReadLine());
            var x10 = (Week)x9;
            Console.WriteLine(x9 + " день недели  - " + x10);

            /////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Задача 10");
            List<int> numbers = new List<int> { };
            Console.Write("Введите длину массива, потом вводите числа");
            int dlinamassiva = int.Parse(Console.ReadLine());
            int dlinamassiva2 = dlinamassiva;
            while (dlinamassiva > 0)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
                dlinamassiva -= 1;
            }
            numbers.Sort();
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < dlinamassiva2; i++)
            {
                if (i < dlinamassiva2 - 1)
                {
                    Console.Write(numbers[i] + " ");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " ");

                }
            }

            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Задача 11");
            List<int> numbers11 = new List<int> { };
            bool sost = true;
            Console.WriteLine("Введите длину массива, потом вводите числа");
            int dlinamassiva11 = int.Parse(Console.ReadLine());
            int dlinamassiva112 = dlinamassiva;
            while (dlinamassiva11 > 0)
            {
                numbers11.Add(int.Parse(Console.ReadLine()));
                dlinamassiva11 -= 1;
            }
            for (int i = 0; i < dlinamassiva112 - 1; i++)
            {
                if (numbers11[i] > numbers11[i + 1])
                {
                    Console.WriteLine(i + 2 + "элемент массива обрывает возрастающую последовательность");
                    sost = false;
                    break;
                }
                
            }
            if (sost == true)
            {
                Console.WriteLine("Последовательность возрастающая");
            }
        }
    }
}
