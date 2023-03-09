#region Task 1
using System.Xml.Schema;

Console.WriteLine("Enter a string to test");
string task1Input = Console.ReadLine();
if (task1Input.Length >= 5) {
    Console.WriteLine(task1Input.Substring(task1Input.Length - 5));
}
else {
    Console.WriteLine(task1Input);
}
#endregion

Console.WriteLine("=====================");

#region Task 2
Console.WriteLine("Enter a sentance");
string testSentance = Console.ReadLine();
string[] seperatedSentance = testSentance.Split(' ');
foreach (string word in seperatedSentance) {
    Console.WriteLine(word);
}
#endregion

Console.WriteLine("=====================");

#region Task 3
Console.WriteLine("Enter a number");
bool isParsed = int.TryParse(Console.ReadLine(), out int task3Number);
if (isParsed) {
    Console.WriteLine($"The sum of the digits in {task3Number} is {SumOfDigits(task3Number)}");
}
else {
    Console.WriteLine("Invaild input");
}
int SumOfDigits(int num) {
    if (num < 0) {
        num *= -1;
    }
    int sum = 0;
    while (num > 0) {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
#endregion

Console.WriteLine("=====================");

#region Task 4
Console.WriteLine("Enter your date of burth's year:");
int birthYear = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your date of burth's month:");
int birthMonth = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your date of burth's day:");
int birthDay = int.Parse(Console.ReadLine());
Console.WriteLine($"Your current age is {AgeCalculator(new DateTime(birthYear, birthMonth, birthDay))}");

int AgeCalculator(DateTime birthday) {
    DateTime today = DateTime.Now;
    today = today.AddYears(birthday.Year * -1);
    today = today.AddMonths(birthday.Month * -1);
    today = today.AddDays(birthday.Day * -1);
    return today.Year;
}
#endregion