using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Manager : IPay
    {
        public int Salary { get; private set; }

        public int Bonus { get; set; }

        public Manager(int salary)
        {
            Salary = salary;
        }

        public int GetSallary()
        {
            return Salary + Bonus;
        }
    }
}
