using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/*Задание
  Используя Visual Studio, создайте проект по шаблону Console Application 
  Создайте программу для автостанции, в которой вам необходимо создать
  простую коллекцию автомобилей со следующими данными: Марка автомобиля,
  модель, год выпуска, цвет. А также вторую коллекцию с моделью автомобиля,
  именем покупателя и его номером телефона. Используя простейший LINQ запрос,
  выведите на экран информацию о покупателе одного из автомобилей и полную
  характеристику приобретенной ними модели.
*/

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car { marka = "Ford", model = "Kuga", year = 2015, color = "White" },
                new Car { marka = "Audi", model = "A4", year = 2016, color = "Black" }
            };

            List<Person> persons = new List<Person>()
            {
                new Person { model = "Kuga", name = "Senya", number = "+30991234567" },
                new Person { model = "A4", name = "Denis", number = "+30991234567" },
                new Person { model = "Kuga", name = "Denis", number = "+30991234567" }

            };

            var result = from per in persons
                         join auto in cars on per.model equals auto.model
                         select new
                         {
                             Name = per.name,
                             Number = per.number,
                             Marka = auto.marka,
                             Model = auto.model,
                             Year = auto.year,
                             Color = auto.color
                         };

            foreach (var pair in result)
            {
                Console.WriteLine("Name: {0} \tphone: {1}", pair.Name, pair.Number);
                Console.WriteLine("Marka: {0} \tModel: {1}\nYear: {2} \tColor: {3}\n",
                    pair.Marka, pair.Model, pair.Year, pair.Color);
            }
            Console.ReadKey();

            
        }
    }

    public class Car
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
    }

    public class Person
    {
        public string model { get; set; }
        public string name { get; set; }
        public string number { get; set; }

    }
}
