using System;
using System.Collections;
using System.Collections.Generic;

namespace ConvolutionalСode.source
{
    class Nesystem:BaseCode
    {
        private string[,] values = new string[,] {
            {"000", "00"},
            {"001", "11"},
            {"010", "10"},
            {"100", "11"},
            {"011", "01"},
            {"101", "00"},
            {"110", "01"},
            {"111", "10"} };

        public Nesystem()
        {
            SetCodeValues(values);
        }   

        public String DeCode(String data)
        {
            String result = "";
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
