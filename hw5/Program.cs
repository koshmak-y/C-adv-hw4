using System;
using System.Collections.Generic;
using System.Collections;

/* Задание
 * Используя Visual Studio, создайте проект по шаблону Console Application
 * Создайте программу, в которой, используя динамические и анонимные типы данных, 
 * создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание.
*/

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dictionary = new ArrayList()
            {
                new { word = "hello", translate = "привет" },
                new { word = "bye", translate = "прощание" },
                new { word = "he", translate = "он" },
                new { word = "she", translate = "она" },
                new { word = "them", translate = "они" },
                new { word = "it", translate = "'это" },
                new { word = "like", translate = "нравиться" },
                new { word = "take", translate = "принимать" },
                new { word = "get", translate = "получить" },
                new { word = "put", translate = "положил" }
            };

            foreach (var pair in dictionary)
            {
                dictionary = String.Format("{0} - {1}", pair.word, pair.translate);
                Console.WriteLine(dictionary);
            }
            Console.ReadKey();
        }
    }
}
