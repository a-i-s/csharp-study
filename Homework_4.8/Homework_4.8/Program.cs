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
            /* int income;
             int expense;
             int profit;

             Random rand = new Random();

             Console.WriteLine($"{"месяц",16}   {"доход,тыс.руб",16}   {"расход,тыс.руб",16}   {"прибыль,тыс.руб.",16}");
             for (int i = 1; i < 13; i++)
             {
                 income = rand.Next(1, 100);
                 expense = rand.Next(1, 100);
                 profit = income - expense;

                 Console.WriteLine($"{i,16}   {income,16}   {expense,16}   {profit,16}");
             }
             Console.ReadKey();*/

            int[] incomeArray = { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
            int[] expenseArray = { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };

            int[] profitArray = new int[12];

            Console.WriteLine($"{"месяц",16}   {"доход,тыс.руб",16}   {"расход,тыс.руб",16}   {"прибыль,тыс.руб.",16}");
            for (int i = 0; i < 12; i++)
             {
              profitArray[i] = incomeArray[i] - expenseArray[i];
              Console.WriteLine($"{i+1,16}   {incomeArray[i],16}   {expenseArray[i],16}   {profitArray[i],16}");
             }
            Console.ReadKey();
        }

    }

}

