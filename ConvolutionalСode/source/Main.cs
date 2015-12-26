using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalСode.source
{
    class Main
    {
        public static void MainFucn()
        {
            Catostrophycal code = new Catostrophycal();
            String result = "";
            result = code.Code("00101110");
            result = code.DeCode(result);
            result = "" + result;
        }
    }
}
