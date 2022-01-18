using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicMathLib
{
    public class HzClass
    {
        public double GetHz(double division, double steps, int wave)
        {
            double set = Math.Pow(2, steps / division);
            double v = wave * set;
            return Math.Round(v, 2);
        }
    }
}
