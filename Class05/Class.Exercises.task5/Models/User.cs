using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Exercises.task5.Models {
    public class User {
        public User(string username, string password, string[] messages)
        {
            Random random = new Random();
            Id = random.Next(1000, 9999);
            Username = username;
            Password = password;
            Messages = messages;
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Messages = new string[0];
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public string GetMessages()
        {
            string output = "";
            foreach(string message in Messages)
            {
                output += $"{message}\n";
            }
            return output;
        }
    }
}
