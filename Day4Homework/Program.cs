using System;
using System.Collections.Generic;

namespace Day4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> days2 = new Dictionary<int, string>();
            days2.Add(1, "Pazartesi");
            Console.WriteLine(days2.Count);
            foreach (var day in days2)
            {
                Console.WriteLine(day);
            }

            MyDictionary<int, string> days = new MyDictionary<int, string>();
            days.Add(1, "Pazartesi");
            days.Add(2, "Salı");
            Console.WriteLine(days.Count);
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("[" + days.Keys[i] + ", " + days.Values[i] + "]");
            }

        }
    }
}
