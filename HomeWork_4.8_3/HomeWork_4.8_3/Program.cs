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
            int rows = Convert.ToInt32(answer);

            Console.WriteLine("Введите количество столбцов матрицы:");
            answer = Console.ReadLine();
            int columns = Convert.ToInt32(answer);

            Console.WriteLine("Введите число, на которое будет производиться умножение:");
            answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);


            int[,] matrix = new int[rows, columns]; //создаем двумерный массив из строк и столбцов
            Random r = new Random(); //случайным образом заполняем данный массив
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next(10); //случайные числа до 10
                }
            }

            Console.WriteLine("Сгенерированный массив:");
            Print(matrix);
            
            Console.WriteLine("Умноженная матрица при помощи метода:");
            int[,] compositionMatrix = Composition(matrix, number); // ввели переменную compositionMatrix и положили в нее метод
            //Composition, который перемножаем основную матрицу на число
            Print(compositionMatrix); // используем Print для вывода новой перемноженной матрицы

            // умножение матрицы на число
            int[,] megamatrix = new int[rows, columns]; //создаем новый масств
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

            //генерируем вторую матрицу
            int[,] matrixTwo = new int[rows, columns]; //создаем двумерный массив из строк и столбцов
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixTwo[i, j] = r.Next(10); //случайные числа до 10
                }
            }

            Console.WriteLine("Сгенерированный второй массив:");
            Print(matrixTwo);

            //складываем матрицы
            int[,] matrixAddition = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixAddition[j, i] = matrix[j, i] + matrixTwo[j, i]; //заполняем новый массив
                }
            }
            
            Console.WriteLine("Сложенная матрица при помощи метода:");
            int[,] additionMatrix = Addition(matrix, matrixTwo); // ввели переменную additionMatrix и положили в нее метод
            //Addition, который складывает матрицы
            Print(additionMatrix); // используем Print для вывода новой сложенной матрицы

            Console.WriteLine("Новый массив суммы:");
            Print(matrixAddition);

            //вычитаем матрицы
            int[,] matrixDifference = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixDifference[j, i] = matrix[j, i] - matrixTwo[j, i]; //заполняем новый массив
                }
            }

            Console.WriteLine("Новый массив разности:");
            Print(matrixDifference);

            //умножение матриц
            int[,] matrix1 =
            {
                { 1, 2, 3 }
            }; //задаем первую матрицу

            int[,] matrix2 =
            {
                { 4 },
                { 5 },
                { 6 }
            }; //задаем вторую матрицу

            var rowsCount = matrix1.GetLength(0); //вводим переменную количество строк в первом массиве
            var columnsCount = matrix2.GetLength(1); //вводим переменную количество столбцов во втором массиве

            int[,] resultMatrix = new int[rowsCount, columnsCount]; //создаем третий массив результат 
            for (int i = 0; i < rowsCount; i++) //проходится по строкам первого массива
            {
                for (int j = 0; j < columnsCount; j++) //проходимся по столбцам второго массива
                {
                    int sum = 0; //получаем каждый элемент новой матрицы результат
                    for (int k = 0; k < matrix1.GetLength(1); k++) //для прохождения по всем элементам строки или столбца
                    {
                        sum = (matrix1[i, k] * matrix2[k, j]) + sum;
                    }
                    resultMatrix[i, j] = sum; //записываем новую матрицу из полученных элементов суммы
                }
            }

            Console.WriteLine("Новый массив, полученный при умножении двух матриц:");
            Print(resultMatrix); //применяем метод для вывода в консоль данных новой матрицы
            
            
            Console.WriteLine("Произведение двух матриц при помощи метода:");
            int[,] compositionTwoMatrix = СompositionTwo(matrix, matrixTwo); // ввели переменную compositionTwoMatrix и положили в нее метод
            //CompositionTwo, который перемножает две заданные матрицы
            Print(compositionTwoMatrix); // используем Print для вывода новой перемноженной матрицы
            Console.ReadKey(); //получили заполненный массив
        }
        
        

        static string GetString(int[] array) //метод для получения строки из массива
        {
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i] + " ";
            }

            return result;
        }

        static void Print(int[,] array) //выводит в консоль переданный массив
        {
            for (int j = 0; j < array.GetLength(0); j++) // проходимся по строкам 
            {
                string result = "";

                for (int i = 0; i < array.GetLength(1); i++) // формируем строку из элементов внутреннего массива
                {
                    result = result + array[j, i] + " ";
                }

                Console.WriteLine(result); // печатаем полученную строку
            }
        }

        //Создаем метод, принимающий матрицу и число, а возвращающий матрицу умноженную на число 
        static int[,] Composition(int[,] matrix, int number)
        {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int j = 0; j < rows; j++) // проходимся по строкам 
            {
                for (int i = 0;
                    i < columns;
                    i++) // формируем строку из элементов внутреннего массива(проходимся по столбцам)
                {
                    result[j, i] = matrix[j, i] * number; //заполняем новый массив
                }
            }

            return result;
        }

        //Создаем метод, принимающий 2 матрицы, а возвращающий их сумму
        static int[,] Addition(int[,] matrix, int[,] matrixTwo)
        {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            int[,] matrixAddition = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixAddition[j, i] = matrix[j, i] + matrixTwo[j, i]; //заполняем новый массив
                }
            }
            return matrixAddition;
        }
    
        //Создаем метод, принимающий 2 матрицы, а возвращающий их произведение
        static int[,] СompositionTwo(int[,] matrix, int[,] matrixTwo)
        {
            int[,] matrix1 =
            {
                { 1, 2, 3 }
            }; //задаем первую матрицу

            int[,] matrix2 =
            {
                { 4 },
                { 5 },
                { 6 }
            }; //задаем вторую матрицу

            var rowsCount = matrix1.GetLength(0); //вводим переменную количество строк в первом массиве
            var columnsCount = matrix2.GetLength(1); //вводим переменную количество столбцов во втором массиве

            int[,] resultMatrix = new int[rowsCount, columnsCount]; //создаем третий массив результат 
            for (int i = 0; i < rowsCount; i++) //проходится по строкам первого массива
            {
                for (int j = 0; j < columnsCount; j++) //проходимся по столбцам второго массива
                {
                    int sum = 0; //получаем каждый элемент новой матрицы результат
                    for (int k = 0; k < matrix1.GetLength(1); k++) //для прохождения по всем элементам строки или столбца
                    {
                        sum = (matrix1[i, k] * matrix2[k, j]) + sum;
                    }
                    resultMatrix[i, j] = sum; //записываем новую матрицу из полученных элементов суммы
                }
            }
            return resultMatrix;
        }
    }   
}