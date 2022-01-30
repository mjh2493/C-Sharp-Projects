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
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Mallory", LastName = "Humphries", Id = 1 });
            employees.Add(new Employee() { FirstName = "Mike", LastName = "Hogan", Id = 2 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", Id = 3 });
            employees.Add(new Employee() { FirstName = "Jill", LastName = "Brown", Id = 4 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Traldi", Id = 5 });
            employees.Add(new Employee() { FirstName = "Megan", LastName = "Howell", Id = 6 });
            employees.Add(new Employee() { FirstName = "Dave", LastName = "Ike", Id = 7 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Bond", Id = 8 });
            employees.Add(new Employee() { FirstName = "Caroline", LastName = "Grant", Id = 9 });
            employees.Add(new Employee() { FirstName = "Greyson", LastName = "Mallory", Id = 10 });
            List<string> newList = new List<string>();

            // foreach loops for finding employee Joe
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add("Employee is: " + employee.FirstName + " " + employee.LastName + " and their ID is " + employee.Id);
                }
            }

            foreach (string employee1 in newList)
            {
                Console.WriteLine(employee1);
            }

            Console.WriteLine("Below shows all employees with ID that is greater than 5."); 
            // lambda for finding employees ID greater than 5
            List<Employee> newEmployees = employees.Where(x => (x.Id > 5)).ToList();

            foreach (Employee employee2 in newEmployees)
            {
                Console.WriteLine("Employee is: " + employee2.FirstName + " " + employee2.LastName + " and their ID is " + employee2.Id);
            }
            

            //IQuittable quitter = new Employee();
            //quitter.Quit();

            //if (employee.Id == employee2.Id)
            //{
            //    Console.WriteLine("These employees have the same ID!");
            //}
            //else
            //{
            //    Console.WriteLine("These employees are not the same.");
            //}

            //// calls method from Person class to show the name of the employee
            //employee.SayName();
            //employee2.SayName();

            //// compares employee with employee 2 to see if their IDs are the same
            //if (employee.Id == employee2.Id)
            //{
            //    Console.WriteLine("These employees have the same ID!");
            //}
            //else
            //{
            //    Console.WriteLine("These employees are not the same.");
            //}
            Console.ReadLine();
        }
    }
}
