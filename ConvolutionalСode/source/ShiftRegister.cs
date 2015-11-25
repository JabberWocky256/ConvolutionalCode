using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    /**
    * Регистр сдвига
    */
    class ShiftRegister
    {
        private BitArray registerArray;
        private int maxSize = 0;
        public ShiftRegister(int maxSize)
        {
            this.maxSize = maxSize;
            registerArray = new BitArray(this.maxSize);
        }

        public void put(Byte bitValue)
        {
            if (bitValue == 0 || bitValue == 1 ) {
                bool bitBooleanValue = bitValue == 1 ? true : false;
                shift();
                registerArray.Set(0, bitBooleanValue);
            }
        }

        public Byte[] Get()
        {
            byte[] result = new byte[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                result[i] = registerArray.Get(i) == true ? (byte)1 : (byte)0;
            }

            shift();
            return new byte[] { 1, 0, 1};
        }


        private void shift()
        {
            for (int i = maxSize - 1; i > 0; i--)
            {
                registerArray.Set(i, registerArray.Get(i - 1));
            }
        }

    }
}
