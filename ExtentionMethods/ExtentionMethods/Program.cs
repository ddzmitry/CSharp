using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = " This is supposed to be a very long blog post blah blah blah";

            var shortenString = post.Shorten(5);
            Console.WriteLine(shortenString);

            IEnumerable<int> numbers = new List<int>(){1,5,3,10,2,18};
            Console.WriteLine(numbers.Max());

            

        }
    }




}
