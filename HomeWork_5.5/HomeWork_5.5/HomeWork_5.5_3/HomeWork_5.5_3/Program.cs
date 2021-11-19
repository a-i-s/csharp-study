using System;

namespace HomeWork_5._5_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "ППППООГГГГОООДДДДДДААААААА"; // ввели переменную в которой лежит наша страка текста
          
            string newText = RemoveDuplicates(text);  // создали переменную для записи окончательного решения, т.е. написанного метода

            Console.WriteLine("Метод удаления дубликатов");
            Console.WriteLine("Заданная строка:  " + text);
            Console.WriteLine("Полученная строка:  " + newText);
        }
        static string RemoveDuplicates(string text) // метод удаления дубликатов
        {
            string result = ""; // переменная для получения окончательного результата
            char lastChar = '\0'; // последний символ выведенный из цикла (какая-то буква)
            char[] letterArray = text.ToCharArray(); // создали массив букв из строки.
            // Преобразовали строку в массив букв с помощью метода ToCharArray
            for (int i = 0; i < letterArray.Length; i++) // циклом прошлись по массиву букв
            {
                if (i == 0) // условие для первой итерации
                {
                    lastChar = letterArray[i];//первый раз присваеваем ПУСТОЙ переменной lastChar значение (инициализируем ее)
                    result = result + letterArray[i];// находим чему равен result на первой итерации цикла
                    continue; // выходим из этого условия и продалжаем идти по циклу
                }

                if (letterArray[i] != lastChar) // условие: если буква массива НЕ равна предыдущей букве массива, то
                {
                    lastChar = letterArray[i]; // эту букву кладем в lastChar
                    result = result + letterArray[i]; // в результатае склеиваем прудыдущий результат и новую полученную букву
                }
            }
            return result; // метод RemoveDuplicates возвращает полученный результат (в данном случае в метод Main)
        }
    }
}