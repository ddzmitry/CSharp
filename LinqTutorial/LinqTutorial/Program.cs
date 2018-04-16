using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqTutorial

{
    class Program
    {


        static void Main(string[] args)
        {

            var p = new Params(1,2,3);
            foreach (var param in p)
            {
                Console.WriteLine(p);
            }

            var dzmitry = new Person("Dzmitry","Alegavich","Dubarau");
            //person.names is INumerable because we set it up 
            // and yield property will excute it one by one
            foreach (var dzmitryName in dzmitry.Names)
            {
                Console.WriteLine(dzmitryName);
            }



            Console.WriteLine("Hello World!");
            var list = new List<int>() {1, 5, 2, 3, 6, 7, 8};
            
            // LINQ select
            var anotherList = list.Select(x => x * x)
                .Where(y => y > 10)
                .ToList();

            anotherList.ForEach(Console.WriteLine);


        }

    }
}
