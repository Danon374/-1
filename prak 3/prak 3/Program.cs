using System;

namespace Prak_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для переключения между октавами нажмите - F8." + '\n' +  "Переключение между октавами:" + '\n' + "F1 - 1 октава" + '\n' + "F2 - 2 октава" + '\n' + "F3 - 3 октава" + '\n' + "F4 - 4 октава" + '\n' + "F5 - 5 октава" + '\n' + "F6 - 6 октава" + '\n' + "F7 - 7 октава" + '\n' + " " + '\n' + "Для выхода из программы нажмите - Escape");
            ConsoleKeyInfo entrance = Console.ReadKey();
            do
            {
                if (entrance.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("1 октава");
                    Console.Clear();
                    OktAVKA_number_1();
                }
                if (entrance.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("2 октава");
                    Console.Clear();
                    OktAVKA_number_2();
                }
                if (entrance.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("3 октава");
                    Console.Clear();
                    OktAVKA_number_3();
                }
                if (entrance.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("4 октава");
                    Console.Clear();
                    OktAVKA_number_4();
                }
                if (entrance.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("5 октава");
                    Console.Clear();
                    OktAVKA_number_5();
                }
                if (entrance.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("6 октава");
                    Console.Clear();
                    OktAVKA_number_6();
                }
                if (entrance.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("7 октава");
                    Console.Clear();
                    OktAVKA_number_7();
                }
            } while (entrance.Key != ConsoleKey.Escape);
        }
        static void OktAVKA_number_1()
        {
            double[] OktAVKA = new double[] { 65.41, 69.30, 73.42, 77.78, 82.41, 87.31, 92.50, 98.00, 103.8, 110.0, 116.5, 123.5 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_2()
        {
            double[] OktAVKA = new double[] { 130.8, 138.6, 146.8, 155.6, 164.8, 174.6, 185.0, 196.0, 207.7, 220.0, 233.1, 246.9 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_3()
        {
            double[] OktAVKA = new double[] { 261.6, 277.2, 293.7, 311.1, 329.6, 349.2, 370.0, 392.0, 415.3, 440.0, 466.2, 493.9 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_4()
        {
            double[] OktAVKA = new double[] { 523.3, 554.4, 587.3, 622.3, 659.3, 698.5, 740.0, 784.0, 830.6, 880.0, 932.3, 987.8 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_5()
        {
            double[] OktAVKA = new double[] { 1047, 1109, 1175, 1245, 1319, 1480, 1568, 1661, 1760, 1865, 1976 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_6()
        {
            double[] OktAVKA = new double[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            Sounds(OktAVKA);
        }
        static void OktAVKA_number_7()
        {
            double[] OktAVKA = new double[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            Sounds(OktAVKA);
        }

        static void Sounds(double[] OktAVKA)
        {
            ConsoleKeyInfo H = Console.ReadKey();
            switch (H.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep((int)OktAVKA[0], 100);
                    break;
                case ConsoleKey.W:
                    Console.Beep((int)OktAVKA[1], 100);
                    break;
                case ConsoleKey.E:
                    Console.Beep((int)OktAVKA[2], 100);
                    break;
                case ConsoleKey.R:
                    Console.Beep((int)OktAVKA[3], 100);
                    break;
                case ConsoleKey.T:
                    Console.Beep((int)OktAVKA[4], 100);
                    break;
                case ConsoleKey.Y:
                    Console.Beep((int)OktAVKA[5], 100);
                    break;
                case ConsoleKey.U:
                    Console.Beep((int)OktAVKA[6], 100);
                    break;
                case ConsoleKey.I:
                    Console.Beep((int)OktAVKA[7], 100);
                    break;
                case ConsoleKey.O:
                    Console.Beep((int)OktAVKA[8], 100);
                    break;
                case ConsoleKey.P:
                    Console.Beep((int)OktAVKA[9], 100);
                    break;
                case ConsoleKey.A:
                    Console.Beep((int)OktAVKA[10], 100);
                    break;
                case ConsoleKey.F8:
                    Main();
                    break;
            }
        }
    }
}
