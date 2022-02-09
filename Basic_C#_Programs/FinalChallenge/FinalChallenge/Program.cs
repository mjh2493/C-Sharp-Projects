using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        public class StudentContext : DbContext
        {
            public StudentContext() : base()
            {

            }
            public DbSet<Student> Students {get; set;}
        }
        
        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var newStud = new Student() { FirstName = "Mallory", LastName = "Humphries", EmailAddress = "mallory@gmail.com" };

                ctx.Students.Add(newStud);
                ctx.SaveChanges();
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
        }
    }
}
