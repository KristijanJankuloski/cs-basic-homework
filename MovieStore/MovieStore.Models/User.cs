using MovieStore.Models.Enums;

namespace MovieStore.Models
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

        public string GetInfo()
        {
            return $"{FirstName} {LastName} | Registered on {DateOfRegistration}";
        }
    }
}