using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var firm = new Firm();
            firm.EmployeeAdded += Firm_EmployeeAdded;
            Console.WriteLine("To quit enter q!");
            while (true)
            {
                Console.WriteLine("Enter employee type:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Contracter");
                Console.WriteLine("3. Stuffmember");
                Console.WriteLine("4. Volunteer");

                var employeeType = Console.ReadLine();
                switch (employeeType)
                {
                    case "1":
                        Console.Write("Enter base salary: ");
                        var manager = new Manager(int.Parse(Console.ReadLine()));
                        Console.Write("Enter bonus: ");
                        manager.Bonus = int.Parse(Console.ReadLine());
                        firm.AddEmployee(manager);
                        break;
                    case "2":
                        Console.Write("Enter working houres: ");
                        var hours = Console.ReadLine();
                        Console.Write("Enter hour rate:");
                        var hourRate = Console.ReadLine();
                        var contracter = new Contracter(int.Parse(hours), int.Parse(hourRate));
                        firm.AddEmployee(contracter);
                        break;
                    case "3":
                        Console.Write("Enter base salary: ");
                        var stuffmember = new Stuffmember(int.Parse(Console.ReadLine()));
                        firm.AddEmployee(stuffmember);
                        break;
                    case "4":
                        var volonteer = new Volunteer();
                        firm.AddEmployee(volonteer);
                        break;
                    case "q":
                        Console.WriteLine("-------------");
                        break;
                    default:
                        Console.WriteLine("Employee type not valid!");
                        break;
                }
                if(employeeType == "q")
                {
                    break;
                }
            }    

            Console.WriteLine($"Monthly cost:  {firm.MonthlyPayment()}");
        }

        private static void Firm_EmployeeAdded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("A new Employee was added.");
        }
    }
}
