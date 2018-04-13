using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public  void GenericFilter(Photo photo)
        {
            Console.WriteLine("Applying Generic filter");
        }

        public void AddContrast(Photo photo)
        {
            Console.WriteLine("Adding Contrast");
        }
    }
}