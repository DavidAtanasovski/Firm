using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Contracter : IPay
    {
        public int Hours { get; private set; }
        public int ByHour { get; set; }

        public Contracter(int hours, int byhour)
        {
            Hours = hours;
            ByHour = byhour;
        }

        public int GetSallary()
        {
            return Hours * ByHour;
        }
    }
}
