using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homework_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] incomeArray = { 100000, 120000, 180000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
            int[] expenseArray = { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };

            int[] profitArray = new int[12];

            Console.WriteLine($"{"месяц",16}   {"доход,тыс.руб",16}   {"расход,тыс.руб",16}   {"прибыль,тыс.руб.",16}");
            for (int i = 0; i < 12; i++) // находим прибыль в каждом месяцце
             {
              profitArray[i] = incomeArray[i] - expenseArray[i];
              Console.WriteLine($"{i+1,16}   {incomeArray[i],16}   {expenseArray[i],16}   {profitArray[i],16}");
             }
            Console.ReadKey();

            int counter = 0;
            for (int i = 0; i < profitArray.Length; i++)
            {
                if (profitArray[i] > 0) counter++; // ищем положительную прибыль
            }
            Console.WriteLine($"Месяцев с положительной прибылью: {counter}");
            Console.ReadKey();

            int[] minProfitArray = new int[3];
            for (int j = 0; j < 3; j++)
            {
                int min = profitArray[0]; // находим минимальное значение прибыли
                                 
                for (int i = 1; i < profitArray.Length; i++)
                {
               
                    int current = profitArray[i]; 
                    if (current < min) {

                       bool isFound = false; // найдено ли такое минимальное значение в массиве минимальных значений
                
                       if (j>0) {
                           for (int k = 0; k < j; k++)
                           {
                            if (minProfitArray[k] == current) { // если текущее значение уже есть в 
                                isFound = true;                 // массиве минимальных значений, мы запоминаем
                                break;                          // факт, что оно найдено и выходлим
                                }
                            }
                        }
                        if (!isFound) min = current;
                    }
                }
                minProfitArray[j] = min; 
            }
            // далее находим месяцы с минимальной прибылью
            string months = "";
            for (int t = 0; t < minProfitArray.Length; t++)
                {
                 int number = minProfitArray[t]; // запомнили элемент из массива минимальных значений
                
                for (int g = 0; g < profitArray.Length; g++)
                {
                    int number2 = profitArray[g]; // запомнили элемент из массива значений прибыли
                    if (number == number2) {
                      months = months + (g+1) + " ";
                     }
                }
           }
            Console.WriteLine($"Худшая прибыль в месяцах: {months}");
        Console.ReadKey();
        }
    }
}

