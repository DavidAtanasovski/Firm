using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Stuffmember : IPay
    {
        public int Salary { get; private set; }

        public Stuffmember(int salary)
        {
            Salary = salary;
        }

        public int GetSallary()
        {
            return Salary;
        }
    }
}
