using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string Name;
        public void display()
        {
            Console.WriteLine("I am an aimal");
        } 
        class Dog : Animal
        {
            public void getname ()
            {
                Console.WriteLine("My name is " + Name);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Dog labrador = new Dog();
                labrador.Name = "Rohu";
                labrador.display();
                labrador.getname();
                Console.ReadLine();
            }
        }
    }
}
