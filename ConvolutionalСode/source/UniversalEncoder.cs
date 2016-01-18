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
            string result = "";
            int diffValue = Int32.MaxValue;
            while (maxValue >= 0)
            {
                string input = Convert.ToString(maxValue, 2);
                while(input.Length < length)
                {
                    input = "0" + input;
                }

                string output = code.Code(input);
                int localDiffCount = getDiffValue(output, message);
                if (localDiffCount < diffValue)
                {
                    diffValue = localDiffCount;
                    result = input;
                }
                if (diffValue == 0)
                {
                    break;
                }
                maxValue--;   
            }

            return result;
        }

        private static int getDiffValue(string v1, string v2)
        {
            int count = 0;
            char[] v1Arr = v1.ToCharArray();
            char[] v2Arr = v2.ToCharArray();
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1Arr[i] != v2Arr[i]) {
                    count++;
                }
            }

            return count;
        }
    }
}
