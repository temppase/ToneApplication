using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonalityLibrary
{
    public class ToneClass
    {
        double v { get; set; }
        public string value = "";
        public Dictionary<char, double> Keys = new Dictionary<char, double>()
        {
            {'1',0 },
            {'2',1 },
            {'3',2 },
            {'4',3 },
            {'5',4 },
            {'6',5 },
            {'7',6 },
            {'8',7 },
            {'q',8 },
            {'w',9 },
            {'e',10 },
            {'r',11 },
            {'t',12 },
            {'y',13 },
            {'u',14 },
            {'i',15 },
            {'a',16 },
            {'s',17 },
            {'d',18 },
            {'f',19 },
            {'g',20 },
            {'h',21 },
            {'j',22 },
            {'k',23 },
            {'z',24 },
            {'x',25 },
            {'c',26 },
            {'v',27 },
            {'b',28 },
            {'n',29 },
            {'m',30 }
        };
        public double GetHz(double division, double steps, int wave)
        {
            double set = Math.Pow(2, steps / division);
            v = wave * set;
            return Math.Round(v, 2);
        }
        public string PlayNotes(ConsoleKeyInfo c, double div, int wave)
        {
            foreach (var i in Keys)
            {
                if (i.Key == c.KeyChar)
                {
                    value = GetHz(div, i.Value, wave).ToString();
                }
            }
            return $"  {value} Hz   ";
        }
        public int WaveChange(ConsoleKeyInfo c, int wave)
        {
            if (c.Key == ConsoleKey.UpArrow)
            {
                return wave * 2;
            }
            if (c.Key == ConsoleKey.DownArrow)
            {
                return wave / 2;
            }
            if (c.Key == ConsoleKey.LeftArrow)
            {
                return wave - 1;
            }
            if (c.Key == ConsoleKey.RightArrow)
            {
                return wave + 1;
            }
            else
            {
                return wave;
            }
        }
    }
}
