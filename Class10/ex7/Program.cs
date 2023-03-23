using ex7.Models;

List<Student> students = new List<Student>();
students.Add(new Student("John", "Doe", "CSS"));
students.Add(new Student("Kiko", "Jj", "Js Basic"));
students.Add(new Student("Bob", "Fuu", "C#"));

List<Group> groups = new List<Group>();
groups.Add(new Group("G1", students));

Academy academy = new Academy("SEDC", 150, groups);