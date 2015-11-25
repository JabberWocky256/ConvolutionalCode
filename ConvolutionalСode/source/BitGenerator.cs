using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class BitGenerator
    {

        private Random rand = new Random();
        public byte Next()
        {
            byte bite = 0;
            bite = rand.Next() >= 0.5 ? (byte)0 : (byte)1;
            return bite;
        }
    }
}
