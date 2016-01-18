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
    }
}
