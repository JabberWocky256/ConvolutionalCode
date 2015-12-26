using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class Catostrophycal:BaseCode
    {
        private string[,] values = new string[,] {
            {"000", "00"},
            {"001", "01"},
            {"010", "10"},
            {"100", "11"},
            {"011", "11"},
            {"101", "10"},
            {"110", "01"},
            {"111", "00"} };


        public Catostrophycal()
        {
            SetCodeValues(values);
        }

        public string DeCode(string data)
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
                    if (i > 0)
                    {
                        if (potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 1].ToString().Substring(1, 2))
                        {
                            result = GetResult(result, potentialResult, i, i + 2, length);
                            continue;
                        } else if(potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 2].ToString().Substring(1, 2)) { 

                            result = GetResult(result, potentialResult, i, i + 2, length);
                            continue;
                        }
                    }
                    else
                    {
                        result = GetResult(result, potentialResult, i, i + 2, length);
                            continue;
                    }
                }
                if (potentialResult[i].ToString().Substring(1, 2) == potentialResult[i + 3].ToString().Substring(0, 2))
                {
                    if (i > 0)
                    {
                        if (potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 1].ToString().Substring(1, 2))
                        {
                            result = GetResult(result, potentialResult, i, i - 1, length);
                            continue;
                        }
                        else if(potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 2].ToString().Substring(1, 2)) {
                            result = GetResult(result, potentialResult, i, i - 2, length);
                            continue;
                        }
                    }
                    else
                    {
                        result = GetResult(result, potentialResult, i, i + 3, length);
                            continue;
                    }

                }
                if (potentialResult[i + 1].ToString().Substring(1, 2) == potentialResult[i + 2].ToString().Substring(0, 2))
                {
                    if (i > 0)
                    {
                        if (potentialResult[i + 1].ToString().Substring(0, 2) == potentialResult[i - 1].ToString().Substring(1, 2))
                        {
                            result = GetResult(result, potentialResult, i + 1, i - 1, length);
                            continue;
                        }
                        else if (potentialResult[i + 1].ToString().Substring(0, 2) == potentialResult[i - 2].ToString().Substring(1, 2)) {
                            result = GetResult(result, potentialResult, i + 1, i - 2, length);
                            continue;
                        }
                    }
                    else
                    {
                        result = GetResult(result, potentialResult, i, i + 2, length);
                        continue;
                    }
                }
                if (potentialResult[i + 1].ToString().Substring(1, 2) == potentialResult[i + 3].ToString().Substring(0, 2))
                {
                    if (i > 0)
                    {
                        if (potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 1].ToString().Substring(1, 2))
                        {
                            result = GetResult(result, potentialResult, i + 1, i - 1, length);
                            continue;
                        }
                        else if (potentialResult[i].ToString().Substring(0, 2) == potentialResult[i - 2].ToString().Substring(1, 2)) {
                            result = GetResult(result, potentialResult, i, i - 2, length);
                            continue;
                        }
                    }
                    else
                    {
                        result = GetResult(result, potentialResult, i + 1, i + 3 + 1, length);
                        continue;
                    }
                }
            }

            return result;
        }

        private static string GetResult(string result, ArrayList potentialResult, int i, int j, int length)
        {
            result += potentialResult[i].ToString().Substring(0, length);
            if (length == 3)
            {
                result += potentialResult[j].ToString().Substring(2, 1);
            }

            return result;
        }
    }
}
