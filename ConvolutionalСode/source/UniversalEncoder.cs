using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class UniversalEncoder
    {
        public static string Encode(BaseCode code, String message)
        {
            int length = message.Length / 2 + 2;
            int maxValue = (int)Math.Pow(2, length) - 1;
            string output = "";
            while (maxValue >= 0)
            {
                string input = Convert.ToString(maxValue, 2);
                while(input.Length < length)
                {
                    input += "0" + input;
                }

                output = code.Code(input);
                if (output.Equals(message))
                {
                    break;
                }
                    
            }

            return output;
        }

    }
}
