using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Exercises.task2.Models {
    public class Student {
        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Student name: {Name}\nStudying at {Academy} in group {Group}");
        }
    }

}
