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

        public ArrayList DeCodeForPotentialResult(string data)
        {
            if (data.Length % 2 != 0)
            {
                return null;
            }

            char[] inputData = data.ToCharArray();
            ArrayList potentialResult = new ArrayList();
            for (int i = 1; i < inputData.Length; i = i + 2)
            {
                AddPotentialResult(potentialResult, inputData, i);
            }

            
            return potentialResult;
        }

        private void checkForEquals(Dictionary<string, int> accounts, ArrayList potentialResulе, int index, int length)
        {
            foreach (string threChars in potentialResulе)
            {
                for (int i = 0; i < values.Length / 2; i++)
                {
                    string key = values[i, 0];
                    if (key.Substring(index, length).Equals(threChars.Substring(index, length)))
                    {
                        accounts[key] = accounts[key] + 1;
                    }
                }
            }
        }

        private void AddPotentialResult(ArrayList potentialResult, char[] inputData, int i)
        {
            string twoChars = inputData[i - 1].ToString() + inputData[i].ToString();
            for (int j = 0; j < values.Length / 2; j++)
            {
                if (values[j, 1].Equals(twoChars))
                {
                    potentialResult.Add(values[j, 0]);
                }
            }
        }
    }
}
