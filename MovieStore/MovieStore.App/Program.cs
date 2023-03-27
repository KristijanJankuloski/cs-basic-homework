using MovieStore.App.Services;
using MovieStore.Models.Enums;
using MovieStore.Models.Models;

MovieService movieService = new MovieService();
EmployeeService employeeService = new EmployeeService();
MemberService memberService = new MemberService();

memberService.Members.Add(new Member(2, "John", "Doe", 23, "jd", "jd", Subscriptions.Monthly));

int userSelect = 0;
userSelect = LoginLoop(userSelect);
Console.WriteLine(userSelect);

int LoginLoop(int selection)
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
        if(selection == 1)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Log in as Employee");
        Console.ResetColor();
        if(selection == 2)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        Console.WriteLine("Exit");
        Console.ResetColor();
        ConsoleKey key = Console.ReadKey(true).Key;
        if(key == ConsoleKey.Enter)
        {
            Console.Clear();
            return selection;
        }
        else if(key == ConsoleKey.UpArrow)
        {
            selection = selection == 0 ? 0 : selection - 1;
            continue;
        }
        else if( key == ConsoleKey.DownArrow)
        {
            selection = selection == 2 ? 2 : selection + 1;
            continue;
        }

    }
}