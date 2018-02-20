using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Animal animal = new cat();
            animal.walk();
            Console.WriteLine(animal.add(30,20));
            Console.ReadLine();

        }
    }

    internal class Cat
    {
    }
}
