using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[][] triangleArray = new int[25][];

            for (int i = 0; i < triangleArray.Length; i++)
            {
                triangleArray[i] = new int[i + 1];// для каждого элемента внешнего массива создается внутренний массив
                for (int j = 0; j < triangleArray[i].Length; j++)
                {
                    if (j == 0 || j == i) // для первого и последнего элемента строки
                    {
                        triangleArray[i][j] = 1; // всегда 1
                    }
                    else
                    {
                        triangleArray[i][j] = triangleArray[i - 1][j - 1] + triangleArray[i - 1][j]; //во всех остальных случаях
                    }
                    Console.Write(triangleArray[i][j] + "\t");
                }
                Console.Write("\n");
            }

             Console.ReadKey();
        }
    }
}
