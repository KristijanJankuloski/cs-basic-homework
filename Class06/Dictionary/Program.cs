Dictionary<string, string> phoneBook = new Dictionary<string, string>();
phoneBook.Add("Martin", "070/222-333");
phoneBook.Add("John", "070/222-111");
phoneBook.Add("Kiko", "070/555-333");
phoneBook.Add("Bob", "070/222-123");
phoneBook.Add("Greg", "070/298-333");

Console.WriteLine("Enter a name to search: ");
string input = Console.ReadLine();

if (phoneBook.ContainsKey(input))
{
    Console.WriteLine(phoneBook[input]);
}
else
{
    Console.WriteLine("name was not found");
}