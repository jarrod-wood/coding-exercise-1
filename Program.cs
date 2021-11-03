using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 1, 1, 3, 3, 3, 3, 3, 5, 5, 6, 6, 7 };
            Console.WriteLine($"Input: {string.Join(",", numbers)}");
            Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();
            /*
            3: 1
            4: 3
            2: 1
            1: 1
            6: 2
            */
            foreach (var i in numbers)
            {
                if (!numbersDictionary.ContainsKey(i))
                {
                    numbersDictionary.Add(i, 1);
                }
                else
                {
                    numbersDictionary[i] += 1;
                }
            }

            var list = (from x in numbersDictionary.Values select x).Distinct().ToList();
            var largestValue = list.Max();

            for (var i = largestValue; i > 0; i--)
            {
                foreach (var j in numbersDictionary.Keys)
                {
                    var currentValue = numbersDictionary[j];
                    if (i <= currentValue)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(""); //

            }

            foreach (var i in numbersDictionary.Keys)
            {
                Console.Write(i);
            }

            Console.Read();
        }
    }
    
}
