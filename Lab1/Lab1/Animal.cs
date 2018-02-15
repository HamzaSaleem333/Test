using System;

namespace Lab1
{
    abstract class Animal
    {
        public abstract void run();
        public abstract void walk();
        public void w() { Console.WriteLine("Implementation"); }
        public virtual int add(int x, int y)
        {
            return x + y;
        }
    }
}