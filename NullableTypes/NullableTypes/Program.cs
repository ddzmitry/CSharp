using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine("GetValueOrDefault() " + date.GetValueOrDefault());
            Console.WriteLine("HasValue " + date.HasValue);
            Console.WriteLine($"Value {(date.HasValue && date.HasValue)}");

            // if Null Convention is to GetValueOrDefault()
            DateTime date2 = date.GetValueOrDefault();
            Console.WriteLine(date2);

            DateTime? date3 = null;
            DateTime date4;


            //date4 = date3 != null ? date3.GetValueOrDefault() : DateTime.Today;
            // same as Previous
            date4 = date3 ?? DateTime.Today;
            Console.WriteLine(date4);

        }
    }
}
