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
        public int BufferSize { get; set; }


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



        




        public string Encode(string[] functionalGenerators, string inputData)
        {
            Stack<char> resultStack = new Stack<char>();

            string res = "";

            List<char> currentBuffer = new List<char>(BufferSize);
            for (int i = 0; i < BufferSize; i++)
            {
                currentBuffer.Add('0');
            }
            
            //for (int i = inputData.Length - 1; i >= 0; i--)
            
            for (int i = 0; i < inputData.Length; i++)
            {
                for (int j = BufferSize - 1; j > 0; j--)
                {
                    currentBuffer[j] = currentBuffer[j - 1];
                }
                currentBuffer[0] = inputData[i];

                for (int j = 0; j < functionalGenerators.Length; j++)
                {
                    res += (ConvertBooleanToChar(Adder(functionalGenerators[j], currentBuffer)));
                }

                res += " ";
                //resultStack.Push(ConvertBooleanToChar(Adder("101", currentBuffer)));               
                //resultStack.Push(ConvertBooleanToChar(Adder("110", currentBuffer)));
                //resultStack.Push(' ');

                //res += ConvertBooleanToChar(Adder("111", currentBuffer));
                //res += ConvertBooleanToChar(Adder("011", currentBuffer));
                //res += ConvertBooleanToChar(Adder("101", currentBuffer));
                //res += " ";
            }

            return res;
            //return String.Concat(
            //    resultStack.Where(c => resultStack.Contains(c)));
        }


        // returns bool value for one iteration of single generator
        private bool Adder(string functionalGenerator, List<char> currentBuffer)
        {

           // List<char> buffer = currentBuffer.ToList<char>();

            char[] generatorArray = functionalGenerator.ToCharArray();
            
            List<bool> valuesToAdd = new List<bool>(); // copy values for further XOR operations

            for (int i = 0; i < generatorArray.Length; i++)
            {
                if (generatorArray[i] == '1')
                {
                    valuesToAdd.Add(ConvertCharToBoolean(currentBuffer[i]));
                }
            }

            bool result = Convert.ToBoolean(valuesToAdd[0]);
            
            for (int i = 1; i < valuesToAdd.Count; i++)
            {
                result ^= valuesToAdd[i];
            }

            return result;
        }


        private bool ConvertCharToBoolean(char input)
        {
            return (input == '0') ? false : true;
        }

        private char ConvertBooleanToChar(bool input)
        {
            return (input == false) ? '0' : '1';
        }

    }
}
