using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an employee object 
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // calls method from Person class to show the name of the employee
            employee.SayName();
            Console.ReadLine();
        }
    }
}
