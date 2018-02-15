using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
  
        class cat : Animal
        {


            public override void run()
            {
                Console.WriteLine("Cat is Running");

            }

            public override void walk()
            {
                Console.WriteLine("Cat is Walking");
            }

            public override int add(int x, int y)
            {
                return x - y;
            }



        }
    }

