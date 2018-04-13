using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {


        static void Main(string[] args)
        {
            var process = new PhotoProcessor();
            var filters = new PhotoFilters();
            // Setting our delegator || using .NET Action  
            Action<Photo> filterHandler = filters.AddContrast;

            filterHandler += filters.GenericFilter;
            filterHandler += removeRedEye;
            
            //we pass filter here so itr will apply functions through delegators
            process.Process("photo.jpg", filterHandler);
        }

        static void removeRedEye(Photo photo)
        {
            Console.WriteLine("Applying red eye");
        }
    }


}
