using System;

namespace HomeWork_5._5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "А ББ ВВВ .ГГГГ ДД, ЖЖЖ";// ввели переменную в которой лежит наша страка текста
            Console.WriteLine(MinWord(text)); // выводим в консоль самое маленькое слово, используя метод MinWord
        }
        static string MinWord(string text) // применили метод для нахождения самого маленького слова в строке
        {
            var result = ""; // ввели переменную в которую потом запишем самое маленькое слово строки

            // char[] separators = new char[] { ' ', '.', ',' };
            char[] separators = " .,".ToCharArray();// создали массив символов из строки. Преобразовали строку в массив символов с помощью метода ToCharArray
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);// методом Split разбиваем исходную строку на слова при помощи символов и записываем их в переменную words

            for (int i = 0; i < words.Length; i++) // циклом проходимся по всем словам 
            {
                var currentWord = words[i]; // временная переменная для текущего слова
                if (result == "") // если в result еще ничего нет, то
                {
                    result = currentWord; // помещаем в него текущее слово
                    continue; // завершение текущей итерации цикла (идем по циклу дальше)
                }
                
                if (result.Length > currentWord.Length) // если длина слова которое лежит сейчас в result больше, длины 
                // слова во временной переменной для текущего слова, то
                {
                    result = currentWord; // меняем  result на слово, к-е лежит во временной переменной для текущего слова
                }
            }
            return result; // минимальное слово
        }
    }
}