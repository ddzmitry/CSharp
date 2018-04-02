using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string name;
        public int age;

        public void Intro(string to)
        {
            Console.WriteLine("Hello {0}, I am {1} and I love you!", to, name);
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person dzmitry = new Person("Dzmitry",25);
            dzmitry.Intro("Anastasia");
        }
    }
}
