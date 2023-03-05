string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Jon", "Bob", "Steve", "Chriss", "Jake" };

Console.WriteLine("Please enter the number of the group to display (1 or 2)");
bool isParsed = false;
isParsed = int.TryParse(Console.ReadLine(), out int inputNum);
while (!isParsed || (inputNum != 1 && inputNum != 2)) {
    Console.WriteLine("You have not entered a corect number plase try again");
    isParsed = int.TryParse(Console.ReadLine(), out inputNum);
}

if(inputNum == 1) {
    foreach(string student in studentsG1) {
        Console.WriteLine(student);
    }
}
else {
    foreach(string student in studentsG2) {
        Console.WriteLine(student);
    }
}