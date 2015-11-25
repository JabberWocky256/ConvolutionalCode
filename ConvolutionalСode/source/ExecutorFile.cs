using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class ExecutorFile
    {
        public static ArrayList Neprerivniy()
        {
            ArrayList arrayOutPut = new ArrayList();
            ArrayList arrayInPut = new ArrayList();
            Neprerivniy neprerivniy = new Neprerivniy();
            for (int i = 0; i < 10; i++)
            {
                byte inputValue = neprerivniy.NewBit();
                arrayInPut.Add(inputValue);
                byte[] outPut = neprerivniy.Get();
                arrayOutPut.Add(outPut[0]);
                arrayOutPut.Add(outPut[1]);
            }

            return arrayOutPut;
        }
    }
}
