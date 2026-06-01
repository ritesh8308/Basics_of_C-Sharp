class Student
{
    public string Name   { get; set; }
    public int Age       { get; set; }
    public double Grade  { get; set; }
}

List<Student> students = new List<Student>
{
    new Student { Name = "Ritesh", Age = 22, Grade = 87.5 },
    new Student { Name = "Rahul",  Age = 20, Grade = 92.0 },
    new Student { Name = "Rohit",  Age = 23, Grade = 65.0 },
    new Student { Name = "Ravi",   Age = 21, Grade = 78.5 },
    new Student { Name = "Reena",  Age = 22, Grade = 95.0 }
};

// Filter
var passing = students.Where(s => s.Grade >= 70);

// Sort by grade descending
var ranked = students.OrderByDescending(s => s.Grade);

// Get just names
var names = students.Select(s => s.Name);

// Top 3 students
var top3 = students.OrderByDescending(s => s.Grade).Take(3);

// Average grade
double avg = students.Average(s => s.Grade);

// Best student
Student best = students.OrderByDescending(s => s.Grade).First();
Console.WriteLine($"Best: {best.Name} — {best.Grade}");

// Chain multiple operations
var result = students
    .Where(s => s.Age >= 21)
    .OrderByDescending(s => s.Grade)
    .Select(s => $"{s.Name}: {s.Grade}");

foreach (var r in result)
    Console.WriteLine(r);