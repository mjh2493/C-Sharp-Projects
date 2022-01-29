using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + "\n" + "Id: " + Id);
        }

        public void Quit()
        {
            Console.WriteLine("Employee number " + Id + " has quit the company.");
        }

        // overrides the == and !== operators- you have to do both with these
        public static bool operator == (Employee idOne, Employee idTwo)
        {
            bool status = false;
            if (idOne == idTwo)
            {
                status = true;
            }
            return status;
        }

        public static bool operator != (Employee idOne, Employee idTwo)
        {
            bool status = false;
            if (idOne != idTwo)
            {
                status = true;
            }
            return status;
        }
    }
}
