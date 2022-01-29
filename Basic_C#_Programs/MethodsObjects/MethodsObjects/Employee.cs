using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects
{
    // employee class inherits from person class
    public class Employee : Person
    {
        // added an additional property
        public int Id { get; set; }
    }
}
