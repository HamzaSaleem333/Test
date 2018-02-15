using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
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
