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
    }
}
