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



        }
    }
}
