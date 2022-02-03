using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Assignment...");

            // set my const 
            const string myName = "Mallory Humphries";

            // print out my const
            Console.WriteLine("My name is {0} and this demonstrates and const.", myName);

            // assign fname
            Console.WriteLine("Write your first name: ");
            string fname = Console.ReadLine();

            //using var to create new employee
            var employee = new Employee(fname);
            Console.WriteLine("Welcome {0} {1}! Your id is: {2}", employee.fname, employee.lname, employee.id);


            Console.ReadLine();
        }

       
        public class Employee
        {
            public string fname;
            public string lname;
            public int id;
            public Employee(string fname, string lname, int id)
            {
                this.fname = fname;
                this.lname = lname;
                this.id = id;
            }
            // pulls in a default last name and id if only one var is set
            public Employee(string fname) : this (fname, "Default Last Name", 100)
            {

            }
            public Employee(string fname, string lname) : this(fname, lname, 25) { }
        }
    }
}
