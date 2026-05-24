class Student
{
    // Properties
    public string Name { get; set; }
    public int Age  { get; set; }
    private double[] grades;

    // Constructor
    public Student(string name, int age, double[] grades)
    {
        this.Name   = name;
        this.Age    = age;
        this.grades = grades;
    }

    // Methods
    public double GetAverage()
    {
        double sum = 0;
        foreach (double g in grades)
            sum += g;
        return sum / grades.Length;
    }

    public string GetGradeLetter()
    {

    // // ✅ Early return — clean, flat, easy to read

    /*
    One line rule

     return makes separate if safe 
     — because the method exits immediately and lower conditions never run. 
     Without return, always use else if. 👍
    */
    
        double avg = GetAverage();
        if (avg >= 90) return "A";
        if (avg >= 75) return "B";
        if (avg >= 60) return "C";
        if (avg >= 40) return "D";
        return "F";
    }

    public void PrintReport()
    {
        Console.WriteLine($"Name:    {Name}");
        Console.WriteLine($"Age:     {Age}");
        Console.WriteLine($"Average: {GetAverage():F2}");
        Console.WriteLine($"Grade:   {GetGradeLetter()}");
    }
}

// In Main
Student s = new Student("Ritesh", 22, new double[] { 85, 92, 78, 95, 88 });
s.PrintReport();