using MovieStore.Models.Enums;

namespace MovieStore.Models.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public UserRoles Role { get; set; }

        public User() { }
        public User(string firstName, string lastName, int age, string username, string password, UserRoles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = username;
            Password = password;
            Role = role;
            DateOfRegistration = DateTime.Now;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName} | Registered on {DateOfRegistration}";
        }
    }
}