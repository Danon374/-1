using System;
using System.Collections.Generic;

namespace Praktika2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Par;
            do
            {
                Console.WriteLine(" " + '\n' + "Для переключение на нужную программу нажмите: 1, 2, 3, (чтобы выйти из неё нажмите 4). " + '\n' + "1. Игра 'Угадай число'" +
                '\n' + "2. Таблица умножения" + '\n' + "3. Вывод делителей числа" + '\n' + "4. Закрыть программу" + '\n' + " ");
                Par = Convert.ToInt32(Console.ReadLine());
                if (Par == 1)
                {
                    Guess_the_number();
                    Console.WriteLine('\n' + "Вы завершили игру!" + '\n' + " " + '\n' + "Нажмите на любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (Par == 2)
                {
                    Multiplication_Table();
                    Console.WriteLine('\n' + " " + '\n' + "Нажмите на любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (Par == 3)
                {
                    Divisor_number();
                    Console.WriteLine('\n' + "Вы завершили операцию." + '\n' + " " + '\n' + "Нажмите на любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (Par != 4);
            Console.Clear();
            Console.WriteLine("Вы вышли из программы.");
        }

        static void Guess_the_number()
        {
            Console.WriteLine("Угадайте число от 0 до 100!");
            Random Opponent = new Random();
            int k = Opponent.Next(0, 100);
            int b;
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b > k)
                {
                    Console.WriteLine("Надо меньше");
                }
                if (b < k)
                {
                    Console.WriteLine("Надо больше");
                }
            } while (k != b);
            Console.WriteLine("Поздравляю, вы угадали число!");
        }

        static void Multiplication_Table()
        {
            Console.WriteLine();
            Console.WriteLine("Таблица умножения: ");
            Console.WriteLine("___________________________________________________________________");
            int[,] box = new int[10, 10];
            for (int A = 1; A < box.GetLength(0); A++)
            {
                for (int B = 1; B < box.GetLength(1); B++)
                {
                    Console.Write(box[A, B] + (A * B) + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("___________________________________________________________________");
        }

        static void Divisor_number()
        {
            string sqrt = "";
            Console.WriteLine("");
            Console.WriteLine("Введите число: ");
            int U = Convert.ToInt32(Console.ReadLine());
            List<int> haners = new List<int>();
            for (int S = 1; S < U; S++)
            {
                if (U % S == 0)
                {
                    haners.Add(S);

                }
            }
            foreach (int i in haners)
            {
                sqrt = sqrt + i.ToString() + '\t';
            }
            Console.WriteLine("");
            Console.WriteLine("Список делителей числа " + U.ToString() + ": " + '\n' + sqrt);
        }
    }
}

