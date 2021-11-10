using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4._8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            string answer = Console.ReadLine();
            int  rows = Convert.ToInt32(answer);

            Console.WriteLine("Введите количество столбцов матрицы:");
            answer = Console.ReadLine();
            int columns = Convert.ToInt32(answer);

            Console.WriteLine("Введите число, на которое будет производиться умножение:");
            answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            
            Console.WriteLine("Сгенерированный массив:");
            int[,] matrix = new int[rows,columns];//создаем двумерный массив из строк и столбцов
            Random r = new Random();//случайным образом заполняем данный массив
            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    matrix[i, j] = r.Next(10);//случайные числа до 10
                }
            }
            Print(matrix);
            
            // умножение
            int[,] megamatrix = new int[rows,columns];//создаем новый масств
            for (int j = 0; j < matrix.GetLength(0); j++) // проходимся по строкам 
            {
                for (int i = 0;
                    i < matrix.GetLength(1);
                    i++) // формируем строку из элементов внутреннего массива(проходимся по столбцам)
                {
                    megamatrix[j, i] = matrix[j, i] * number; //заполняем новый массив
                }
            }
            Console.WriteLine("Новый умноженный массив:");
            Print(megamatrix);

            Console.ReadKey();//получили заполненный массив
        }
        
        static string GetString(int[] array)//метод для получения строки из массива
        {
            string result = "";

            for(int i = 0; i < array.Length; i++)
            {
                result = result + array[i] + " ";
            }

            return result;
        }
        static void Print(int[,] array)//выводит в консоль переданный массив
        {
            for(int j = 0; j < array.GetLength(0); j++) // проходимся по строкам 
            {
                string result = "";

                for (int i = 0; i < array.GetLength(1); i++) // формируем строку из элементов внутреннего массива
                {
                    result = result + array[j,i] + " "; 
                }
                Console.WriteLine(result);// печатаем полученную строку
            }
        }
    }
}
