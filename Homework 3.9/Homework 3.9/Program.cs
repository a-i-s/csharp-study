using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра\"Угадайка\"");
            string gamer1, gamer2;
            Console.WriteLine("Игрок 1, введите свой никнейм:");
            gamer1 = Console.ReadLine();
            Console.WriteLine("Игрок 2, введите свой никнейм:");
            gamer2 = Console.ReadLine();
            Random rand = new Random();
            int gameNumber = rand.Next(12, 120); //программа загадывает случайное число от 12 до 120
            Console.WriteLine("Начальное число: " + gameNumber); //это число сообщается игрокам

            int rightAnswer = 0;//ввели переменную правильный результата
            int gamer1Number;
            int gamer2Number;

            while (true)
            {
                Console.Write("Игрок 1 введите число от 1 до 4: ");
                gamer1Number = GetUserInput();
                gameNumber = gameNumber - gamer1Number; // gameNumber -= gamer1number
                Console.WriteLine("Число:  " + gameNumber);
                if (gameNumber == rightAnswer)
                {
                    Console.WriteLine("Ура, gamer1Number - вы победили!");
                    break;
                }
               
                Console.WriteLine("Игрок 2 введите число от 1 до 4: ");
                gamer2Number = GetUserInput();
                gameNumber = gameNumber - gamer2Number;
                Console.WriteLine("Число:  " + gameNumber);
                if (gameNumber == rightAnswer)
                {
                    Console.WriteLine("Ура, gamer2Number - вы победили!");
                    break;
                }
            }

            Console.ReadKey();
        }

        static int GetUserInput()
        {
            int result = 0;
            while (true)
            {
                result = Convert.ToInt32(Console.ReadLine());
                if (result < 1 || result > 4)
                {
                    Console.WriteLine("Введите число от 1 до 4");
                }
                else break;

            }
            return result;
        }
       
    }
}
 