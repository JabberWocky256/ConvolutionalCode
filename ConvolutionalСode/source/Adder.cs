using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class Adder
    {
        public static int add(byte first, byte second)
        {
            if ((first == 0 && second == 0) || (first == 1 && second == 1))
            {
                return 0;
            } else if ((first == 0 && second == 1) || (first == 0 && second == 1))
            {
                return 1;
            }

            return -1;
        }
    }
}
