using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7.Models {
    public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteSubject { get; set; }

        public Student(){}
        public Student(string firstName, string lastName, string favoriteSubject)
        {
            FirstName = firstName;
            LastName = lastName;
            FavoriteSubject = favoriteSubject;
        }
    }
}
