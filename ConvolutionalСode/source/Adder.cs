using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class Adder
    {
        public static int Add(byte first, byte second)
        {
            if ((first == 0 && second == 0) || (first == 1 && second == 1))
            {
                return 0;
            } else if ((first == 0 && second == 1) || (first == 1 && second == 0))
            {
                return 1;
            }

            return -1;
        }

        public static int Add(byte[] items)
        {
            byte previousAdded = items[0];
            for (int i = 1; i < items.Length ; i++)
            {
                previousAdded = (byte) Add(items[i], previousAdded);
            }
            return previousAdded;
        }
    }
}
