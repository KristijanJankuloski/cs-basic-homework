using homework5.Models;

Console.WriteLine("Enter your first name");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your last name");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age");
bool isParsed = int.TryParse(Console.ReadLine(), out int age);
if (!isParsed) {
    Console.WriteLine("Invalid age");
    return;
}

Human newHuman = new Human(firstName, lastName, age);

Console.WriteLine(newHuman.GetPersonDetails());