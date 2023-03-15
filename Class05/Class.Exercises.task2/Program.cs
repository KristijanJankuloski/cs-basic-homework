using Class.Exercises.task2.Models;

Student[] students = new Student[] { new Student("Kristijan", "SEDC", "G1"), new Student("John", "Random", "G3"), new Student("Bob", "SEDC", "G2")};

Console.WriteLine("Enter a name to search for:");
string searchInput = Console.ReadLine();

bool isFound = false;
foreach(Student student in students)
{
    if(searchInput.ToLower() == student.Name.ToLower())
    {
        student.PrintInfo();
        isFound = true;
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"No student with name of {searchInput} has been found");
}