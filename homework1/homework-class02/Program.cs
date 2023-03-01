Console.WriteLine("Please insert number:");
bool isConverted = int.TryParse(Console.ReadLine(), out int userInput);
if (isConverted)
{
    Console.WriteLine("Valid number: " + userInput);
}
else
{
    Console.WriteLine("Invalid input");
}