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
            employee.Id = 8495;

            Employee employee2 = new Employee();
            employee.FirstName = "Mallory";
            employee.LastName = "Humphries";
            employee.Id = 9304;

            IQuittable quitter = new Employee();
            quitter.Quit();

            if (employee.Id == employee2.Id)
            {
                Console.WriteLine("These employees have the same ID!");
            }
            else
            {
                Console.WriteLine("These employees are not the same.");
            }

            // calls method from Person class to show the name of the employee
            employee.SayName();
            employee2.SayName();

            // compares employee with employee 2 to see if their IDs are the same
            if (employee.Id == employee2.Id)
            {
                Console.WriteLine("These employees have the same ID!");
            }
            else
            {
                Console.WriteLine("These employees are not the same.");
            }
            Console.ReadLine();
        }
    }
}
