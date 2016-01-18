using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    abstract class BaseCode
    {
        private string[,] values;

        protected void SetCodeValues(string[,] values)
        {
            this.values = values;
        }

        public string Code(string data)
        {
            string result = "";
            char[] inputData = data.ToCharArray();
            for (int i = 2; i < inputData.Length; i++)
            {
                string threeChars = inputData[i - 2].ToString() + inputData[i - 1].ToString() + inputData[i].ToString();
                for (int j = 0; j < values.Length / 2; j++)
                {
                    if (values[j, 0].Equals(threeChars))
                    {
                        result += values[j, 1];
                    }
                }
            }



            return result;
        }

        public string DeCode(string data)
        {
            return UniversalEncoder.Encode(this, data);
        }
    }
}
