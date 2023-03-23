try
{
    Console.WriteLine("Enter a string!");
    string inputStr = Console.ReadLine();
    if(inputStr == null || inputStr == "")
    {
        throw new Exception("No string entered");
    }
}
catch(Exception ex)
{
    Console.WriteLine("No string entred!");
}

try
{
    Console.WriteLine("Enter an integer");
    int inputInt = int.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Didnt input an integer");
}

try
{
    Console.WriteLine("Input a double");
    double inputDouble = double.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Double incorrectly entred");
}

try
{
    Console.WriteLine("Enter a single character");
    char inputChar = char.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Didnt input a char");
}

try
{
    Console.WriteLine("enter true or false");
    bool inputBool = bool.Parse(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine("Unkonwn boolean value");
}