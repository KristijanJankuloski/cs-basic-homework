Console.WriteLine("Enter a number:");

while (true)
{
    try
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(CoolNumber(inputNumber));
        break;
    }
    catch(Exception ex)
    {
        Console.WriteLine("Can't you read? Enter a number, not anything else!");
        Console.WriteLine("Enter a proper number");
    }
}

string CoolNumber(int number)
{
    if(number % 100 == 0)
    {
        return "You have entered a cool number!";
    }
    return "The number you've enterd is not cool at all!";
}