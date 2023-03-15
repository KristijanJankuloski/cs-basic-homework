using Class.Exercises.task5.Models;

User[] users = new User[] { 
    new User("john.doe", "password", new string[] { "Hi john", "Its bob", "how are you" }), 
    new User("bob.bobski", "1234", new string[] { "Hi Bob", "Im doing well"}),
    new User("chriss", "admin", new string[] { "Work emails", "admin stuff"})
};

Console.WriteLine("Would you like to\n1. Login\n2. Register");
bool isParsed = int.TryParse(Console.ReadLine(), out int userChoice);
if (!isParsed)
{
    Console.WriteLine("Invalid input");
}

if(userChoice == 1)
{
    Console.WriteLine("Enter Usename:");
}
