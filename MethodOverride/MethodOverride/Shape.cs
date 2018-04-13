using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class Circle : Shape
    {
       
        public override void Draw()
        {
            // Use parent method to override its own
            Console.WriteLine("Draw Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Use parent method to override its own
            Console.WriteLine("Draw Rectangle");
        }
    }
    public class Triangle: Shape
    {
        public override void Draw()
        {
            // Use parent method to override its own
            Console.WriteLine("Draw Triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape Method draw");
        }

    }
}
