using MovieStore.App.Services;
using MovieStore.Models.Enums;
using MovieStore.Models.Models;
using System.Linq;

MovieService movieService = new MovieService();
EmployeeService employeeService = new EmployeeService();
MemberService memberService = new MemberService();

memberService.Add("jd", "John", "Doe", "jd", 23, Subscriptions.Monthly);

while (true)
{
    int userSelect = 0;
    userSelect = HomeScreenLoop(userSelect);
    if (userSelect == 0)
    {
        MemberLoop();
    }
    else if (userSelect == 1)
    {
        EmployeeLoop();
    }
    else
    {
        break;
    }
}

void MemberLoop()
{
    Member loggedIn;
    while (true)
    {
        Console.WriteLine("Enter username");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password");
        string password = Console.ReadLine();
        try
        {
            loggedIn = memberService.Login(username, password);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Try again\n");
            continue;
        }
        break;
    }
    while (true)
    {
        int memberSelection = 0;
        memberSelection = MemberOptionsLoop(memberSelection, loggedIn.FirstName);
        if (memberSelection == 0)
        {
            Console.WriteLine(memberService.GetUserInfo(loggedIn.UserName));
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
            continue;
        }
        else if (memberSelection == 1)
        {
            Movie movieToRent = RentingMoviesLoop(movieService.ListAvalable());
            if (movieToRent == null)
            {
                continue;
            }
            movieService.CheckOut(movieToRent);
            memberService.RentMovie(loggedIn.UserName, movieToRent);
            continue;
        }
        else if (memberSelection == 2)
        {
            Movie movieToReturn = ReturnMovieLoop(memberService.GetRentedMovies(loggedIn.UserName));
            if (movieToReturn == null)
            {
                continue;
            }
            movieService.Return(movieToReturn);
            memberService.ReturnMovie(loggedIn.UserName, movieToReturn);
            continue;
        }
        else if (memberSelection == 3)
        {
            foreach(var movie in memberService.GetRentedMovies(loggedIn.UserName))
            {
                Console.WriteLine(movie.GetShortInfo());
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
            continue;
        }
        return;
    }
}
void EmployeeLoop()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter your employee username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter your employee password:");
            string inputPassword = Console.ReadLine();
            Employee loggedInEm = employeeService.LogIn(inputUsername, inputPassword);
            while (true)
            {
                int employeeOptions = 0;
                employeeOptions = EmployeeOptionsLoop(employeeOptions, loggedInEm.FirstName);
                if (employeeOptions == 0)
                {
                    foreach (var movie in movieService.ListAvalable())
                    {
                        Console.WriteLine(movie.GetShortInfo());
                    }
                    Console.WriteLine("\nPress any key to return to options screen");
                    Console.ReadLine();
                    continue;
                }
                else if (employeeOptions == 1)
                {
                    Console.WriteLine("Here are all the registered members\n");
                    foreach (var member in memberService.Members)
                    {
                        Console.WriteLine($"{member.Value.GetInfo()} {member.Key}");
                    }
                    Console.WriteLine("\nPress any key to return to options screen");
                    Console.ReadLine();
                    continue;
                }
                else if (employeeOptions == 2)
                {
                    Console.WriteLine("Choose a username:");
                    string chosenUsername = Console.ReadLine();
                    while (chosenUsername == "" || memberService.IsUsernameTaken(chosenUsername))
                    {
                        Console.WriteLine("The username is not available\nTry again");
                        chosenUsername = Console.ReadLine();
                    }
                    Console.WriteLine("Enter First name");
                    string userFirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    string userLastName = Console.ReadLine();
                    Console.WriteLine("Choose a password");
                    string userPasswrod = Console.ReadLine();
                    Console.WriteLine("Enter user age");
                    bool isParsed = int.TryParse(Console.ReadLine(), out int userAge);
                    while (!isParsed)
                    {
                        Console.WriteLine("Enter a proper number for an age");
                        isParsed = int.TryParse(Console.ReadLine(), out userAge);
                    }
                    Console.WriteLine("Select subscrition type Monthly or Yearly: (M / Y)");
                    string subType = Console.ReadLine().ToLower();
                    while (subType != "m" && subType != "y")
                    {
                        Console.WriteLine("Invalid selection type. Try again");
                        subType = Console.ReadLine().ToLower();
                    }
                    Subscriptions userSub;
                    if (subType == "m")
                        userSub = Subscriptions.Monthly;
                    else
                        userSub = Subscriptions.Anual;
                    memberService.Add(chosenUsername, userFirstName, userLastName, userPasswrod, userAge, userSub);
                    Console.WriteLine("New user has been registered\nPress any key to go back to options screen");
                    Console.ReadLine();
                    continue;
                }
                else if (employeeOptions == 3)
                {
                    try
                    {
                        Console.WriteLine("Enter username if the member to delete:");
                        string usernameToDelete = Console.ReadLine();
                        memberService.Delete(usernameToDelete);
                        Console.WriteLine($"The user with username:{usernameToDelete} has been removed\nPress any key to continue.");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("The username does not exist\nReturn to the options screen and try again\npress any key.");
                        Console.ReadLine();
                    }
                    continue;
                }
                return;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.WriteLine("Please try again.");
            Console.ResetColor();
            continue;
        }
    }
}
int HomeScreenLoop(int selection)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Use arrow keys to navigate options and enter to select:");
        if (selection == 0)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Log in as Member");
        Console.ResetColor();
        if (selection == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Log in as Employee");
        Console.ResetColor();
        if (selection == 2)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Exit");
        Console.ResetColor();
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            return selection;
        }
        else if (key == ConsoleKey.UpArrow)
        {
            selection = selection == 0 ? 0 : selection - 1;
            continue;
        }
        else if (key == ConsoleKey.DownArrow)
        {
            selection = selection == 2 ? 2 : selection + 1;
            continue;
        }

    }
}
int MemberOptionsLoop(int selection, string name)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"=== {name} === Member selection screen:");
        if (selection == 0)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Check personal info");
        Console.ResetColor();
        if (selection == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Rent a movie");
        Console.ResetColor();
        if (selection == 2)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Return a movie");
        Console.ResetColor();
        if (selection == 3)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Check rented movies");
        Console.ResetColor();
        if (selection == 4)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Logout");
        Console.ResetColor();
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            return selection;
        }
        else if (key == ConsoleKey.UpArrow)
        {
            selection = selection == 0 ? 0 : selection - 1;
            continue;
        }
        else if (key == ConsoleKey.DownArrow)
        {
            selection = selection == 4 ? 4 : selection + 1;
            continue;
        }
    }
}
int EmployeeOptionsLoop(int selection, string name)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"=== {name} === Employee selection screen:");
        if (selection == 0)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("List available movies");
        Console.ResetColor();
        if (selection == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("List all members");
        Console.ResetColor();
        if (selection == 2)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Register new member");
        Console.ResetColor();
        if (selection == 3)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Delete existing member");
        Console.ResetColor();
        if (selection == 4)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Logout");
        Console.ResetColor();
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            return selection;
        }
        else if (key == ConsoleKey.UpArrow)
        {
            selection = selection == 0 ? 0 : selection - 1;
            continue;
        }
        else if (key == ConsoleKey.DownArrow)
        {
            selection = selection == 4 ? 4 : selection + 1;
            continue;
        }
    }
}
Movie RentingMoviesLoop(List<Movie> movies)
{
    int selection = 0;
    int offset = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Select movie to rent or press escape to exit\n");
        var moviesPage = offset+6 <= movies.Count? movies.GetRange(offset, 6) : movies.GetRange(offset, movies.Count - offset);
        for (int i=0; i < moviesPage.Count; i++)
        {
            if(i == selection)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine(moviesPage[i].Title);
            Console.ResetColor();
        }
        Console.WriteLine($"\nPage {(offset/6)+1}/{Math.Ceiling(movies.Count/6.0)}");
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.UpArrow)
        {
            selection = selection == 0? 0 : selection - 1;
        }
        else if(key == ConsoleKey.DownArrow)
        {
            selection = selection == moviesPage.Count-1 ? selection : selection + 1;
        }
        else if (key == ConsoleKey.LeftArrow)
        {
            offset = offset == 0 ? 0 : offset - 6;
        }
        else if (key == ConsoleKey.RightArrow)
        {
            offset = offset / 6 == movies.Count / 6 ? offset : offset + 6;
        }
        else if(key == ConsoleKey.Enter)
        {
            return moviesPage[selection];
        }
        else if(key == ConsoleKey.Escape)
        {
            return null;
        }
    }
}
Movie ReturnMovieLoop(List<Movie> movies)
{
    if(movies.Count == 0)
    {
        Console.WriteLine("You have no rented movies\nPress any key to return.");
        Console.ReadLine();
        return null;
    }
    int selection = 0;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Select movie to return or press escape to exit\n");

        for (int i = 0; i < movies.Count; i++)
        {
            if (i == selection)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine(movies[i].Title);
            Console.ResetColor();
        }
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.UpArrow)
        {
            selection = selection == 0 ? 0 : selection - 1;
        }
        else if (key == ConsoleKey.DownArrow)
        {
            selection = selection == movies.Count-1 ? selection : selection + 1;
        }
        else if (key == ConsoleKey.Enter)
        {
            return movies[selection];
        }
        else if (key == ConsoleKey.Escape)
        {
            return null;
        }
    }
}