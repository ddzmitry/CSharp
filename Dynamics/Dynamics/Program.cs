using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = "Dzmitry";

//            var methodInfo = obj.GetType().GetMethod("GetHashCode");
//            methodInfo.Invoke(null, null);

            dynamic excelObject = "Dzmitry";
            //excelObject.Optimize();


            // with dynamics you can reassign
            dynamic name = "Dzmitry";
            name = 10;
            Console.WriteLine(name);


            dynamic a = 10;
            dynamic b = 5;
            var c = a+b;
            System.Console.WriteLine(c);

            // Dynamic will cas as an integer
            int i = 5;
            dynamic d = i;
            long l = d;


        }
    }
}
