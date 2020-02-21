using System;
using System.Linq;

/*Задание
  Используя Visual Studio, создайте проект по шаблону Console Application 
  Создайте программу в которой создайте целочисленную последовательность
  размерностью 30 элементов (последовательность заполнить случайными числами),
  содержащая как положительные, так и отрицательные числа. Вывести ее первый
  положительный элемент и последний отрицательный элемент. 
*/

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] mass = new int[30];
            for (int i=0; i<30; i++)
            {
                mass[i] = rand.Next(-100, 100);
            }
            Console.WriteLine("Целочисельная последовательность чисел: ");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("\n");

            var firstPositiveElement = from value in mass
                                       where value >= 0
                                       select value;

            Console.WriteLine("First positive: " + firstPositiveElement.First());

            var lastNegativeElement = from value in mass
                                       where value < 0
                                       select value;

            Console.WriteLine("Last negative: " + lastNegativeElement.Last());

            Console.ReadKey();
        }
    }
}
