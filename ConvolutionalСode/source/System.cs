using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class System:BaseCode
    {
        private string[,] values = new string[,] {
            {"000", "00"},
            {"001", "01"},
            {"010", "00"},
            {"100", "11"},
            {"011", "01"},
            {"101", "10"},
            {"110", "11"},
            {"111", "10"} };

        public System()
        {
            SetCodeValues(values);
        }

        public string DeCode(String data)
        {
            string result = "";
            ArrayList potentialResult = DeCodeForPotentialResult(data);

            for (int i = 0; i + 3 < potentialResult.Count; i = i + 2)
            {
                int length = 1;
                if (i + 5 >= potentialResult.Count)
                {
                    length = 3;
                }
                if (potentialResult[i].ToString().Substring(1, 2) == potentialResult[i + 2].ToString().Substring(0, 2))
                {
                    result += potentialResult[i].ToString().Substring(0, length);
                    if (length == 3)
                    {
                        result += potentialResult[i + 2].ToString().Substring(2, 1);
                    }
                }
                else if (potentialResult[i].ToString().Substring(1, 2) == potentialResult[i + 3].ToString().Substring(0, 2))
                {
                    result += potentialResult[i].ToString().Substring(0, length);
                    if (length == 3)
                    {
                        result += potentialResult[i + 3].ToString().Substring(2, 1);
                    }
                }
                else if (potentialResult[i + 1].ToString().Substring(1, 2) == potentialResult[i + 2].ToString().Substring(0, 2))
                {
                    result += potentialResult[i + 1].ToString().Substring(0, length);
                    if (length == 3)
                    {
                        result += potentialResult[i + 2].ToString().Substring(2, 1);
                    }
                }
                else if (potentialResult[i + 1].ToString().Substring(1, 2) == potentialResult[i + 3].ToString().Substring(0, 2))
                {
                    result += potentialResult[i + 1].ToString().Substring(0, length);
                    if (length == 3)
                    {
                        result += potentialResult[i + 3].ToString().Substring(2, 1);
                    }
                }
            }

            return result;
        }
    }
}
