using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Models {
    internal class Person {
        public Person(){}
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Age { get; set; }
    }
}
