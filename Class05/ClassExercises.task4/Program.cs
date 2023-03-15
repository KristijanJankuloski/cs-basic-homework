void NumberStats(double number)
{
    bool isPosivite;
    if(number >= 0)
        isPosivite = true;
    else
        isPosivite = false;

    bool isEven;
    if(Math.Truncate(number) % 2 == 0)
        isEven = true;
    else
        isEven = false;

    bool isInteger;
    if(Math.Truncate(number) == number)
        isInteger = true;
    else
        isInteger = false;

    Console.WriteLine($"Stats for number {number}");
    if (isPosivite)
        Console.WriteLine("\tPositive");
    else
        Console.WriteLine("\tNegative");
    if (isEven)
        Console.WriteLine("\tEven");
    else
        Console.WriteLine("\tOdd");
    if(isInteger)
        Console.WriteLine("\tInteger");
    else
        Console.WriteLine("\tDecimal");
}

while(true)
{
    Console.WriteLine("Enter a number:");
    double userIn;
    bool isParsed = double.TryParse(Console.ReadLine(), out userIn);
    while (!isParsed)
    {
        Console.WriteLine("Invalid input Try again:");
        isParsed = double.TryParse(Console.ReadLine(), out userIn);
    }
    NumberStats(userIn);

    Console.WriteLine("Would you like to try another number? (Y/N)");
    string userOption = Console.ReadLine().ToLower();
    if(userOption == "y")
    {
        continue;
    }
    break;
}