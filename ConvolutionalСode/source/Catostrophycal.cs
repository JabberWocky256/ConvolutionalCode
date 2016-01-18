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
    }
}
