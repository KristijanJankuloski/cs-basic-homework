using Class.Exercises.Models;

Console.WriteLine("Enter the name of your dog:");
string dogName = Console.ReadLine();
Console.WriteLine("Enter the breed of your dog:");
string dogRace = Console.ReadLine();
Console.WriteLine("Enter the color of your dog:");
string dogColor = Console.ReadLine();

Dog userDog = new Dog(dogName, dogRace, dogColor);

Console.WriteLine("Enter dog actions:\n\tEat\n\tPlay\n\tChaseTail");
string userAction = Console.ReadLine();

switch (userAction.ToLower())
{
    case "eat":
        Console.WriteLine(userDog.Eat());
        break;
    case "play":
        Console.WriteLine(userDog.Play());
        break;
    case "chasetail":
        Console.WriteLine(userDog.ChaseTail());
        break;
    default: 
        Console.WriteLine("Invaild action");
        break;
}