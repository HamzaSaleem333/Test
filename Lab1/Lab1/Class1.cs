using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Animal
    {
        public abstract void run();
        public abstract void walk();
        public void w() { Console.WriteLine("a123"); }
        public virtual  int add(int x , int y)
        {
            return x + y;
        }
    }
}
