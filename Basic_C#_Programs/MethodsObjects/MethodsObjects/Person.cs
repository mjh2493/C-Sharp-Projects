using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    public class Person
    {
        // two properties of person class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // method to show the first and last name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
