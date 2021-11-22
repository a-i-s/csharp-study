﻿using System;

namespace HomeWork_5._5_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arithmetic = new[] { 2, 4, 6, 8, 10 }; // создали переменную арефметический массив
            Console.WriteLine("Метод по распознованию арифметической прогрессии");
            bool isArithmetic = IsArithmetic(arithmetic); // создали переменную типа bool, которовой присвоили сделанный метод
            Console.WriteLine("Данные числа являются арифметической прогрессией:  " + isArithmetic); // вызвали результат метода

            int[] geometric = new[] { 0, 4, 8, 16, 32 }; // создали переменную арефметический массив
            Console.WriteLine("Метод по распознованию геометрической прогрессии");
            bool isGeometric = IsGeometric(geometric); // создали переменную типа bool, которовой присвоили сделанный метод
            Console.WriteLine("Данные числа являются арифметической прогрессией:  " + isGeometric); // вызвали результат метода

        }

        /// <summary>
        /// метод, принимающий некоторое количество чисел и выясняющий, является ли заданная последовательность элементами арифметической прогрессии
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsArithmetic(int[] number)
        {
            int delta = 0; // переменная для вычисления числа на которое увеличивается последующее
            for (int i = 0; i < number.Length - 1; i++) // циклом проходимся по массиву
            {
                int tempDelta =
                    number[i + 1] - number[i]; // временная переменная для вычисления дельты на каждой итерации
                if (i == 0) // условие для первой итерации
                {
                    delta = tempDelta; // если дельта на первой итерации равна дельте на последующей итерации
                    continue; // выход из условия и переход к следующей итерации цикла
                }

                if (delta != tempDelta)
                    return false; // если дельта на первой итерации НЕ равна дельте на последующих итерациях
                // то выходим из цикла и выдаем полученный результат false
            }

            return true; // выход из цикла и запись результата true
        }

        /// <summary>
        /// метод, принимающий некоторое количество чисел и выясняющий, является ли заданная последовательность элементами геометрической прогрессии
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsGeometric(int[] number)
        {
            if (number.Length < 2 || number[0] == 0) return false; // если длина массива меньше 2 или первый элемент
                                                                   // массива равен 0, то возвращаем значение false
            int delta = 0; // переменная для вычисления числа - во сколько увеличивается последующий элемент массива
            for (int i = 0; i < number.Length - 1; i++) // циклом проходимся по массиву
            {
               int tempDelta = number[i + 1] / number[i]; // временная переменная для вычисления дельты на каждой итерации
                if (i == 0) // условие для первой итерации
                {
                    delta = tempDelta; // если дельта на первой итерации равна дельте на последующей итерации
                    continue; // выход из условия и переход к следующей итерации цикла
                }

                if (delta != tempDelta) return false; // если дельта на первой итерации НЕ равна дельте на последующих итерациях
                // то выходим из цикла и возвращаем полученный результат false
            }
            return true; // выходим из цикла и возвращаем результат true
        }
    }
}

