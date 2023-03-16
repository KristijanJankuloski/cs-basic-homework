using Class.Exercises.task6.Models;

User[] users = new User[] { new User("1234-1234-1234-1234", "0000", "John Doe", 21000) };

while (true)
{
    int homeSlection = 0;
    homeSlection = HomeScreenSelection(homeSlection);
    if (homeSlection == -1)
        return;
    else if (homeSlection == 0)
    {
        ExistingAccountLoop();
    }
    else if (homeSlection == 1)
    {
        RegisterNewAccount();
    }
    else
    {
        return;
    }
}
void ExistingAccountLoop()
{
    int foundUserIndex = -1;

    Console.WriteLine("Enter account number:");
    string requestedAccNumber = Console.ReadLine();
    foundUserIndex = FindUserIndex(requestedAccNumber);
    while (foundUserIndex == -1)
    {
        Console.WriteLine("The account does not exist! Try again.");
        requestedAccNumber = Console.ReadLine();
        foundUserIndex = FindUserIndex(requestedAccNumber);
    }

    Console.WriteLine("Enter your pin:");
    string requestPin = Console.ReadLine();
    bool correctPin = users[foundUserIndex].CheckPin(requestPin);
    while (!correctPin)
    {
        Console.WriteLine("The pin you entered is incorrect! Try again.");
        requestPin = Console.ReadLine();
        correctPin = users[foundUserIndex].CheckPin(requestPin);
    }

    while (true)
    {
        int selectedOption = 0;
        selectedOption = OptionSelectionLoop(selectedOption, users[foundUserIndex].FullName);

        if (selectedOption == 0)
        {
            string bal = users[foundUserIndex].CheckBalance();
            Console.WriteLine($"Your cuurent balance is {bal}");
        }
        else if (selectedOption == 1)
        {
            Console.WriteLine("Enter ammount you'd like to withdraw:");
            double requestAmmount = NumberPrompt();
            bool isSuccessfull = users[foundUserIndex].Withdraw(requestAmmount);
            while (!isSuccessfull)
            {
                Console.WriteLine($"You do not have enough funds for that withdrawl. Try again.");
                requestAmmount = NumberPrompt();
                isSuccessfull = users[foundUserIndex].Withdraw(requestAmmount);
            }
            Console.Clear();
            Console.WriteLine($"You have withdrawn ${requestAmmount} from your account\nYour new balance is {users[foundUserIndex].CheckBalance()}");
        }
        else if (selectedOption == 2)
        {
            Console.WriteLine("Enter deposit ammount:");
            double depositAmm = NumberPrompt();
            bool isSuccessfull = users[foundUserIndex].Deposit(depositAmm);
            while (!isSuccessfull)
            {
                Console.WriteLine("Something went wrong! Try again.");
                depositAmm = NumberPrompt();
                isSuccessfull = users[foundUserIndex].Deposit(depositAmm);
            }
            Console.Clear();
            Console.WriteLine($"Your new balance is {users[foundUserIndex].CheckBalance()}");
        }
        else if (selectedOption == 3)
        {
            return;
        }
        Console.WriteLine("Would you like to preform another action? (Y/N)");
        string anotherActionChoice = Console.ReadLine().ToLower();
        while (anotherActionChoice != "y" && anotherActionChoice != "n")
        {
            Console.WriteLine("Unkown command.");
            anotherActionChoice = Console.ReadLine().ToLower();
        }
        if (anotherActionChoice == "y")
            continue;
        return;
    }

}
void RegisterNewAccount()
{
    Console.WriteLine("Welcome new user!\n");
    Console.WriteLine("Please enter your full name:");
    string fullName = Console.ReadLine();
    Console.WriteLine("Please enter a valid desired account number:\n(XXXX-XXXX-XXXX-XXXX)");
    string cardNumber = Console.ReadLine();
    bool cardExists = false;
    while (!User.ValidateCardNumber(cardNumber))
    {
        Console.WriteLine("The number you have entered is not valid.");
        cardNumber = Console.ReadLine();
    }
    foreach(User user in users)
    {
        if (user.CheckCardNumber(cardNumber))
        {
            cardExists = true;
            break;
        }
    }
    while (cardExists)
    {
        Console.WriteLine("That number is taken!");
        cardNumber = Console.ReadLine();
        while (!User.ValidateCardNumber(cardNumber))
        {
            Console.WriteLine("The number you have entered is not valid.");
            cardNumber = Console.ReadLine();
        }
        cardExists = false;
        foreach (User user in users)
        {
            if (user.CheckCardNumber(cardNumber))
            {
                cardExists = true;
                break;
            }
        }
    }
    Console.WriteLine("Enter a desired pin:");
    string pin = Console.ReadLine();
    User newUser = new User(cardNumber, pin, fullName);
    Array.Resize(ref users, users.Length+1);
    users[users.Length-1] = newUser;
    Console.WriteLine("User has been registered. Welcome!\nPress any key to continue!");
    Console.ReadLine();
}
int HomeScreenSelection(int selectedOption)
{
    do
    {
        Console.Clear();
        Console.WriteLine("Welcome to our bank!\n");
        Console.WriteLine(selectedOption == 0 ? "Login to existing account <-" : "Login to existing account");
        Console.WriteLine(selectedOption == 1 ? "Create a new account <-" : "Create a new account");
        Console.WriteLine(selectedOption == 2 ? "Exit <-" : "Exit");

        ConsoleKey inputKey = Console.ReadKey(true).Key;
        if (inputKey == ConsoleKey.Escape)
            return -1;
        else if (inputKey == ConsoleKey.UpArrow)
            selectedOption = selectedOption == 0 ? 0 : selectedOption - 1;
        else if (inputKey == ConsoleKey.DownArrow)
            selectedOption = selectedOption == 2 ? 2 : selectedOption + 1;
        else if (inputKey == ConsoleKey.Enter)
        {
            Console.Clear();
            return selectedOption;
        }
    } while (true);
}
int OptionSelectionLoop(int selectedOption, string username)
{
    do
    {
        Console.Clear();
        Console.WriteLine($"Welcome back {username}\nSelect options:\n");
        Console.WriteLine(selectedOption == 0 ? "Check Balance <-" : "Check Balance");
        Console.WriteLine(selectedOption == 1 ? "Cash Withdrawal <-" : "Cash Withdrawal");
        Console.WriteLine(selectedOption == 2 ? "Cash Deposit <-" : "Cash Deposit");
        Console.WriteLine(selectedOption == 3 ? "Logout <-" : "Logout");

        ConsoleKey inputKey = Console.ReadKey(true).Key;

        if (inputKey == ConsoleKey.UpArrow)
            selectedOption = selectedOption == 0 ? 0 : selectedOption - 1;
        else if (inputKey == ConsoleKey.DownArrow)
            selectedOption = selectedOption == 3 ? 3 : selectedOption + 1;
        else if (inputKey == ConsoleKey.Enter)
        {
            Console.Clear();
            return selectedOption;
        }
    } while (true);
}
int FindUserIndex(string accNumber)
{
    for (int i = 0; i < users.Length; i++)
    {
        if (users[i].CheckCardNumber(accNumber))
            return i;
    }
    return -1;
}
double NumberPrompt()
{
    bool isParsed = double.TryParse(Console.ReadLine(), out double userInput);
    if (userInput < 0)
        isParsed = false;
    while (!isParsed)
    {
        Console.WriteLine("The input you have entered is not valid please try again");
        isParsed = double.TryParse(Console.ReadLine(), out userInput);
        if (userInput < 0)
            isParsed = false;
    }
    return userInput;
}