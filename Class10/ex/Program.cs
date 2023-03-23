bool flipBool(bool inputB)
{
    return !inputB;
}

try
{
    Console.WriteLine("Enter a boolean value");
    bool userInput = bool.Parse(Console.ReadLine());
    Console.WriteLine(flipBool(userInput));
}
catch(Exception ex)
{
    Console.WriteLine("Incorrect Input");
}