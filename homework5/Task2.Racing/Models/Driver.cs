using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Racing.Models {
    public class Driver {
        public Driver() {
                
        }
        public Driver(string name, double level) {
            Name = name;
            Level = level;
        }

        public string Name { get; set; }
        public double Level { get; set; }
    }
}
