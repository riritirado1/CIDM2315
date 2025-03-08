namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Creating Professors
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);
        
        // Creating Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);
        
        // Printing Professor details
        Console.WriteLine("Professor Details:");
        professor1.PrintInfo();
        professor2.PrintInfo();
        
        // Printing Student details
        Console.WriteLine("\nStudent Details:");
        student1.PrintInfo();
        student2.PrintInfo();
        
        // Calculating and printing results
        double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
        Console.WriteLine($"\nThe salary difference between Alice and Bob is: {salaryDifference}");
        
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}

class Professor
{
    private string profName;
    private string classTeach;
    private double salary;
    
    public Professor(string name, string subject, double salaryAmount)
    {
        profName = name;
        classTeach = subject;
        salary = salaryAmount;
    }
    
    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }
    
    public double GetSalary()
    {
        return salary;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
}

class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;
    
    public Student(string name, string course, double grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = grade;
    }
    
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    
    public double GetGrade()
    {
        return studentGrade;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {studentGrade}");
    }
}
