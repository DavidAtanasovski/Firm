using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public delegate void EmployeeAddedDelegate(object sender, EventArgs eventArgs);
    class Firm
    {
        private List<IPay> lista;

        public event EmployeeAddedDelegate EmployeeAdded;

        public Firm()
        {
            lista = new List<IPay>();
        }
        public void AddEmployee(IPay employee)
        {
            lista.Add(employee);
            if(EmployeeAdded != null)
            {
                EmployeeAdded(this, new EventArgs());
            }
        }

        public int MonthlyPayment()
        {
            int val = 0;
            foreach (var item in lista)
            {
                val += item.GetSallary();
            }
            return val;
        }
    }
}
