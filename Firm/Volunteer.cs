using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Volunteer : IPay
    {
        public int Salary { get; private set; }

        public Volunteer()
        {
            Salary = 0;
        }

        public int GetSallary()
        {
            return Salary;
        }
    }
}
