using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Object_Initializer
{
    public class Person 
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public char Sex;

        //public Person()
        //{

        //}
        //public Person(int id)
        //{
        //    this.Id = id;
        //}
        //public Person(int id, string firstName)
        //    : this(id)
        //{
        //    this.FirstName = firstName;
        //}
        //public Person(int id, string firstName, string lastName)
        //    : this(id, firstName)
        //{
        //    this.LastName = lastName;
        //}
        //public Person(int id, string firstName, string lastName, char sex)
        //    : this(id, firstName, lastName)
        //{
        //    this.Sex = sex;
        //}
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // We can remove the constructors and use Object Initialization syntax to initialize an object

            var person = new Person();
            person.LastName = "John";

            var person2 = new Person
            {
                Id = 1,
                FirstName = "Gaspard",
                LastName = "Meritus",
                Sex = 'm'
            };

            Console.WriteLine( person.LastName);
        }
    }
}
