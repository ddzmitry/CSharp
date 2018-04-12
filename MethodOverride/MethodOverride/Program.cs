using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{

  
    class Program
    {
        static void Main(string[] args)
        {
           //creating list
            var shapes = new List<Shape>();
           //Adding values
           shapes.Add(new Circle{Width = 500} );
           shapes.Add(new Triangle{Width = 500} );

           shapes.Add(new Rectangle{Width = 400,Heigth = 500});
           // init canvas
           var canvas = new Canvas();
           //drawing canvas
           canvas.DrawShapes(shapes);
        }
    }
}
