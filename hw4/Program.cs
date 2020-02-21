using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Collections;


namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<client> clients = new List<client>()
            {
                new client { code = 1, year = 1995, num_mounth = 12, hours = 150 },
                new client { code = 2, year = 1995, num_mounth = 11, hours = 120 },
                new client { code = 3, year = 1994, num_mounth = 10, hours = 120 },
                new client { code = 4, year = 1997, num_mounth = 3, hours = 120 }
            };
            Console.WriteLine("All clients:");
            foreach (var item in clients)
            {
                Console.WriteLine("Code: {0}\t\tHours: {1}\tYear: {2}\tMounth: {3}", item.code, item.hours, item.year, item.num_mounth);
            };
            int MinHours = clients.Min(a => a.hours);
            var result = from person in clients
                         where person.hours == MinHours
                         select person;
            Console.WriteLine("\nClients with min hours:");
            foreach (var item in result)
            {
                Console.WriteLine("Hours: {0} \t Year: {1}\t Mounth: {2}", item.hours, item.year, item.num_mounth);
            };
            Console.WriteLine("\nLast client with min hours:");
            var last = result.Last();
            Console.WriteLine("Hours: {0} \t Year: {1}\t Mounth: {2}", last.hours, last.year, last.num_mounth);
            Console.ReadKey();
                           
        }
    }

    public class client
    {
        public int code { get; set; }
        public int year { get; set; }
        public int num_mounth { get; set; }
        public int hours { get; set; }
    }
}
