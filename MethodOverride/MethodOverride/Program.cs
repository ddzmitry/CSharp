using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class Player
    {
        private string Name;
        private int Health;
        private int AttackPower;

        public Player(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 4;
        }

        public void Fight(Player enemy)
        {
            if (this.Health > 0 && enemy.Health > 0)
            {
                enemy.Health -= AttackPower;
                ShowHealth();
                isDead();
                enemy.Fight(this);
                enemy.Defence(this);
            }

        }

        public void Defence(Player enemy)
        {
            if (this.Health > 0 && enemy.Health > 0)
            {
                var rand = new Random();
                AttackPower += rand.Next(1, 5);
                ShowHealth();
                isDead();
                enemy.Fight(this);
            }

        }

        public void isDead()
        {
            if (this.Health < 0)
            {
                Console.WriteLine("{0} is Dead! Game Over", Name);
                
            }
        }
        public void ShowHealth()
        {
            Console.WriteLine("{0} has {1} health left",Name,Health);
        }
    }
  

    class Program
    {
        static void Main(string[] args)
        {


            /*
             * //creating list
            var shapes = new List<Shape>();
           //Adding values
           shapes.Add(new Circle{Width = 500} );
           shapes.Add(new Triangle{Width = 500} );

           shapes.Add(new Rectangle{Width = 400,Heigth = 500});
           // init canvas
           var canvas = new Canvas();
           //drawing canvas
           canvas.DrawShapes(shapes);
             */


            var mirko = new Player("Mirko");
            var jon = new Player("Jon");
            mirko.Fight(jon);

            
        }
    }
}
