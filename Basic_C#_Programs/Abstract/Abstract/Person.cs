using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // abstract class creation
    public abstract class Person
    {
        // two properties of person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method to show the first and last name
        public abstract void SayName();
    }
}
