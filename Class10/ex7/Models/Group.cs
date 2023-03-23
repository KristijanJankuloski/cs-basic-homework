using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7.Models {
    public class Group {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        private int NumberOfStudents { get; set; }

        public Group(){}
        public Group(string name, List<Student> students)
        {
            Name = name;
            Students = students;
            NumberOfStudents = Students.Count;
        }
    }
}
