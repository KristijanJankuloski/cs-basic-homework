using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7.Models {
    public class Academy {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Group> Groups { get; set; }
        public int Rating { get; set; }

        public Academy(){}
        public Academy(string name, int capacity, List<Group> groups)
        {
            Name = name;
            Capacity = capacity;
            Groups = groups;
        }
    }
}
