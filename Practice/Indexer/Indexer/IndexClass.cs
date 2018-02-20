using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class IndexClass
    {
        public int[] val = new int[10];
        public IndexClass()
        {
            val[0] = 10;
        }
        public int this [int index] {
            get
            {
                return val[index];
            }
        }



    }
}
