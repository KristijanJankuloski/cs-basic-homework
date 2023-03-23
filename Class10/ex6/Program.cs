int CountWords(string input)
{
    return input.Split(" ").Length;
}

Console.WriteLine("Enter a sentance to check it's word count:");
string input = Console.ReadLine();
if(input == "")
{
    Console.WriteLine("Empty");
}
else
{
    Console.WriteLine(CountWords(input));
}