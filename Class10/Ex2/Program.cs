string[] months = new string[] { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
Console.WriteLine("Enter a number between 1 and 12");
bool isParsed = int.TryParse(Console.ReadLine(), out int monthIndex);
while (!isParsed || monthIndex < 1 || monthIndex > 12)
{
    Console.WriteLine("Invalid input try again");
    isParsed = int.TryParse(Console.ReadLine(), out monthIndex);
}
Console.WriteLine($"Your month is {months[monthIndex-1]}");