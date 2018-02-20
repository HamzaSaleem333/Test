using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexClass obj = new IndexClass();
            Console.WriteLine( "Value of Indexer at Index 0 ="+obj[0]);
            Console.ReadKey();
        }
    }
}
