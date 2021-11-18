using System;

namespace HomeWork_5._5
{
    internal class Program
    {
        static string text = "А ББ ВВВ .ГГГГ ДД, ЖЖЖЖ"; // ввели переменную в которой лежит наша страка текста

        public static void Main(string[] args)
        {
            Console.WriteLine(MinWord(text)); // выводим в консоль самое маленькое слово, используя метод MinWord
            
            Print(MaxWords(text)); // используем метод Print для вывода массива максимально длинных слов
        }

        static string MinWord(string text) // применили метод для нахождения самого маленького слова в строке
        {
            var result = ""; // ввели переменную в которую потом запишем самое маленькое слово строки

            // char[] separators = new char[] { ' ', '.', ',' };
            char[]
                separators =
                    " .,".ToCharArray(); // создали массив символов из строки. Преобразовали строку в массив символов с помощью метода ToCharArray
            string[]
                words = text.Split(separators,
                    StringSplitOptions
                        .RemoveEmptyEntries); // методом Split разбиваем исходную строку на слова при помощи символов и записываем их в переменную words

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

        static string[] MaxWords(string text) // применили метод для нахождения массива самых больших слов в строке
        {
            var maxWord = ""; // ввели переменную в которую потом запишем самое длинное слово строки

            // char[] separators = new char[] { ' ', '.', ',' };
            char[]
                separators = " .,".ToCharArray(); // создали массив символов из строки. Преобразовали строку в массив символов с помощью метода ToCharArray
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); // методом Split разбиваем исходную строку на слова
            // при помощи символов и записываем их в переменную words

            for (int i = 0; i < words.Length; i++) // циклом проходимся по всем словам 
            {
                var currentWord = words[i]; // временная переменная для текущего слова
                if (maxWord == "") // если в maxWord еще ничего нет, то
                {
                    maxWord = currentWord; // помещаем в него текущее слово
                    continue; // завершение текущей итерации цикла (идем по циклу дальше)
                }

                if (maxWord.Length < currentWord.Length) // если длина слова которое лежит сейчас в maxWord меньше, длины 
                    // слова во временной переменной для текущего слова, то
                {
                    maxWord = currentWord; // меняем  maxWord на слово, к-е лежит во временной переменной для текущего слова
                }
            }

            int count = 0; // счетчик, который ведет подсчет количества найденных слов
            for (int i = 0; i < words.Length; i++) // цикл для нахождения количества слов, равных по длине maxWord
            {
                if (maxWord.Length == words[i].Length)
                {
                    count++;
                }
            }

            int index = 0; // вводим переменную, в которую записываем найденное подходящее слово
            string[] result = new string[count]; // новый пустой массив для новый найденных слов, равных по длине maxWord
            for (int i = 0; i < words.Length; i++)
            {
                if (maxWord.Length == words[i].Length) // eсли перебираемое слово = maxWord, то кладем это слово в новый пустой массив
                                                       // больших слов одинаковой длины
                {
                    result[index] = words[i];
                    index++;
                }
            }
            return result; // найденный массив слов одинаковой максимальной длины
        }

        static void Print(string[] array) //выводит в консоль переданный массив
        {
            string result = "";
            for (int j = 0; j < array.Length; j++) // проходимся по строкам 
            {
                result = result + array[j] + " ";
            }
            Console.WriteLine(result); // печатаем полученную строку
        }
    }
}