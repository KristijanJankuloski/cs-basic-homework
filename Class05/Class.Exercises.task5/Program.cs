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
    Console.WriteLine("Enter your usename:");
    string userInput = Console.ReadLine();

    int foundUserIndex = -1;
    for(int i=0; i < users.Length; i++)
    {
        if (users[i].Username == userInput)
            foundUserIndex = i;
    }

    if(foundUserIndex == -1)
    {
        Console.WriteLine("No user with that username was found");
    }
    else
    {
        Console.WriteLine("Enter your password");
        string passwordInput = Console.ReadLine();

        if (users[foundUserIndex].Password == passwordInput)
        {
            Console.WriteLine($"{users[foundUserIndex].Username}'s Messages:");
            Console.WriteLine(users[foundUserIndex].GetMessages());
        }
        else
        {
            Console.WriteLine("Incorrect password");
        }
    }
}
else if(userChoice == 2)
{
    Console.WriteLine("Choose a username:");
    string userInput = Console.ReadLine();
    if(userInput.Trim() == "")
    {
        Console.WriteLine("No input found.");
        return;
    }

    bool userAlreadyExists = false;
    foreach(User user in users)
    {
        if(user.Username == userInput)
            userAlreadyExists = true;
    }

    if(userAlreadyExists)
    {
        Console.WriteLine("The username is already taken.");
        return;
    }

    Console.WriteLine("Choose a secure password.");
    string passwrodInput = Console.ReadLine();

    Array.Resize(ref users, users.Length + 1);
    users[users.Length-1] = new User(userInput, passwrodInput);

    Console.WriteLine("New user has been added here are all the users");
    foreach(User user in users)
    {
        Console.WriteLine(user.Username);
    }
}
else
{
    Console.WriteLine("Unknown command.");
}
