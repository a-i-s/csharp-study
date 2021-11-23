using System;

namespace HomeWork_5._5_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numberM = 2;
            int numberN = 2;
            Console.WriteLine(Recursion(numberM, numberN));
        }

        /// <summary>
        /// метод рекурсии для вычисления функции Аккермана
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Recursion(int numberM, int numberN) // m >= 0, n >= 0
        {
            if (numberM == 0) return numberN + 1;

            // m >= 0, n > 0
            if (numberN == 0) return Recursion(numberM - 1, 1);

            // m > 0, n > 0
            return Recursion(numberM - 1, Recursion(numberM, numberN - 1));
        }
    }
}