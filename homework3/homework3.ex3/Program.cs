string[] namesArray = new string[1];

Console.WriteLine("Please enter a name");
namesArray[0] = Console.ReadLine();

for(; ; ) {
    Console.WriteLine("Would you like to enter another name? (Y / N)");
    string optionInput = Console.ReadLine();
    if(optionInput == "n" || optionInput == "N") {
        break;
    }
    if(optionInput != "y" && optionInput != "Y" ) {
        Console.WriteLine("You have not entered a valid option!");
        continue;
    }
    int currentLength = namesArray.Length;
    Array.Resize(ref namesArray, currentLength + 1);
    Console.WriteLine("Enter new name");
    namesArray[currentLength] = Console.ReadLine();
}

Console.WriteLine("Here are all the names");
foreach(string name in namesArray) {
    Console.WriteLine(name);
}