using System;

/*Задание
  Используя Visual Studio, создайте проект по шаблону Console Application.
  Создайте программу в которой создайте класс Calculator, методы которого
  принимают аргументы и возвращают значения типа dynamic.  
*/

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.div(9, "0"));
            Console.ReadKey();
        }
    }
    public class Calculator
    {
        public dynamic add(dynamic value1, dynamic value2)
        {
            try
            {
                return value1 + value2;
            }
            catch
            {
                return "Не удается выполнить операцию";
            }

        }
        public dynamic sub(dynamic value1, dynamic value2)
        {
            try
            {
                return value1 - value2;
            }
            catch
            {
                return "Не удается выполнить операцию";
            }
        }
        public dynamic prod(dynamic value1, dynamic value2)
        {
            try
            {
                return value1 * value2;
            }
            catch
            {
                return "Не удается выполнить операцию";
            }
        }
        public dynamic div(dynamic value1, dynamic value2)
        {
            try
            {
                if (value2 != 0)
                {
                    return value1 / value2;
                }
                return "value2 can not be 0";
            }
            catch
            {
                return "Не удается выполнить операцию";
            }

        }
    }
}
