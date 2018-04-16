using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 73, 32, 76, 79, 86, 69, 32, 89, 79, 85, 32, 65, 78, 65, 83, 84, 65, 83, 73, 65, 33 };
            Console.WriteLine(list.Select(x => (char)x));
            //castinf to a string
            list.ForEach(x => Console.WriteLine((char)x));
            // FizzBuzz in OneLine 
            IEnumerable<string> fizzBuzz = list.Select(x => x % 2 == 0 ? "fizz" : x % 3 == 0 ? "buzz" : x % 15 == 0 ? "fizzBuzz" : x.ToString());
            foreach (var s in fizzBuzz)
            {
                Console.WriteLine(s);
            }


            // materializing collections
            var numbers = Enumerable.Range(1, 10);
            var arr = numbers.ToArray(); // ToList()
            // (key,value)
            var dict = numbers.ToDictionary(i => (double)i / 10, i => i % 2 == 0);
            Console.WriteLine(dict);

            var arr2 = new[] { 1, 2, 3 };
            var arre = arr2.AsEnumerable(); // simply casts to IEnumerable<int>
            ParallelQuery<int> pq = arr2.AsParallel();


        }
    }
}
