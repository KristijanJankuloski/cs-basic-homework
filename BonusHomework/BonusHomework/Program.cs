double totalBalance = 700;
Console.WriteLine("=== ATM ===");

while (true) {
    Console.WriteLine("Please enter what you would like to do.");
    Console.WriteLine("B -- Check avalable balance");
    Console.WriteLine("W -- Withdraw from accaunt");

    string userOptions = Console.ReadLine();
    while (userOptions != "b" && userOptions != "B" && userOptions != "w" && userOptions != "W") {
        Console.WriteLine("You have entered an unrecodnised option!");
        Console.WriteLine("Please ehter either b or w");
        userOptions = Console.ReadLine();
    }

    if (userOptions == "b" || userOptions == "B") {
        Console.WriteLine("Your avalable balance is " + totalBalance + "$");
    }

    else {
        Console.WriteLine("Enter ammount of money you would like to withdraw");
        double withdrawRequest;
        while(true) {
            bool isParsed = double.TryParse(Console.ReadLine(), out withdrawRequest);
            while(!isParsed) {
                Console.WriteLine("You have not entered a valid number please try again.");
                isParsed = double.TryParse(Console.ReadLine(), out withdrawRequest);
            }
            if (withdrawRequest < 0) {
                Console.WriteLine("You entred a number less than 0 please try again.");
                continue;
            }
            if (withdrawRequest > totalBalance) {
                Console.WriteLine("You have entered an ammount larger than your balance of " + totalBalance + "$");
                Console.WriteLine("Please try again!");
                continue;
            }
            break;
        }
        totalBalance -= withdrawRequest;
        Console.WriteLine(withdrawRequest + "$ have been withdrawn from your balance.");
        Console.WriteLine("Your new balance is " + totalBalance + "$");
    }

    Console.WriteLine("Would you like to preform any other action? (Y / N)");
    userOptions = Console.ReadLine();
    while (userOptions != "y" && userOptions != "Y" && userOptions != "n" && userOptions != "N") {
        Console.WriteLine("You have entered an unrecodnised option plase try again");
        userOptions = Console.ReadLine();
    }
    if (userOptions == "y" || userOptions == "Y") {
        continue;
    }
    Console.WriteLine("Thank you for using our ATM");
    break;
}