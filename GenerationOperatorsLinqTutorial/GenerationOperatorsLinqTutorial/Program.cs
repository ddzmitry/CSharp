using System;
using System.Linq;

namespace GenerationOperatorsLinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enumerable.Empty<int>());
            Console.WriteLine(Enumerable.Repeat("Hello",3));
            Console.WriteLine(Enumerable.Range(1, 10));
            // sequens of int char
            Console.WriteLine(Enumerable.Range('a', 'z' - 'a'));
            //sequence of letters
            Console.WriteLine(Enumerable.Range('a', 'z' - 'a').Select(c => (char)c));
            //sequence of charracters 
            Console.WriteLine(Enumerable.Range(1,0).Select(i => new string('x',i)));
        }
    }
}
