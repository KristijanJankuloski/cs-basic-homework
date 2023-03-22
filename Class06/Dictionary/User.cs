using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
    public class User {
        public string Name { get; set; }

        public User(string name)
        {
            if(name == null) throw new Exception("agrument name is null");
            Name = name;
        }
    }
}
