using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class Neprerivniy
    {
        ShiftRegister register = new ShiftRegister(3);
        BitGenerator generator = new BitGenerator();

        public void NewBit()
        {
            register.put(generator.Next());
        }

        public byte[] Get()
        {
            byte[] outPut = register.Get();
            int adder1 = Adder.add((byte)Adder.add(outPut[0], outPut[1]), outPut[2]);
            int adder2 = (byte)Adder.add(outPut[0], outPut[2]);
            outPut = new byte[2];
            outPut[0] = (byte) adder1;
            outPut[1] = (byte) adder2;

            return outPut;
        }
    }
}
