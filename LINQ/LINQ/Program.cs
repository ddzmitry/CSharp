using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            //With select you can select by property
            var cheapBooksTitles = books
                .Where(b => b.Price < 10)
                .Where(b => b.Price < 10)
                .Select(b => b.Title);

            // Linq query Operator like a SQL
            var cheaperBooks = from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // Returning Single Book or Operator || SingleOrDefault will return null as a value
            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(singleBook.Price);

            // can find the first value that matche the query || FirstOrDefalult
            Console.WriteLine(books.First(b => b.Title == "C# Advanced Topics").Title);

            // Last || LastOrDefault
            Console.WriteLine(books.Last(b => b.Title == "C# Advanced Topics").Title);

            // Skiping the data
            Console.WriteLine(books.Skip(2).Take(3).Select(b => b.Title));

            // Aggregators 
            Console.WriteLine("Aggregators");
            Console.WriteLine(books.Count());

            //Max Price
            Console.WriteLine(books.Max(x=>x.Price));

            // Cheppest Price
            Console.WriteLine(books.Min(x=>x.Price));

            // Sum
            Console.WriteLine(books.Sum(b => b.Price));

            // Aggregate fuinctions 
            var list = new List<int>() {13, 18, 25, 12, 16};
            list.Aggregate((a, b) => a + b);

            // Get Avarage
            var avgPrice = books.Average(b => b.Price);
            Console.WriteLine("The avarage book price is {0} ", avgPrice);
            
            
            foreach (var s in books.Skip(2).Take(3).Select(b => b.Title))
            {
                Console.WriteLine("Skipped Book {0} ",s);
            }


            foreach (var cheapBooksTitle in cheapBooksTitles)
            {
                Console.WriteLine(cheapBooksTitle);
            }



            foreach (var book in books.OrderBy(b => b.Title).Where(b => b.Price < 10))
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Price);

            }


        }
    }
}
