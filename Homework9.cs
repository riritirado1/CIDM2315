using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
    // Task 1: Student class
    class Student
    {
        private int studentID;
        private string studentName;

        public static List<Student> studentList = new List<Student>();

        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
        }

        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Create 4 students
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // Task 3: Create gradebook
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                {"Alice", 4.0},
                {"Bob", 3.6},
                {"Cathy", 2.5},
                {"David", 1.8}
            };

            // Task 4: Check if Tom exists
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
                Console.WriteLine("Tom was not found in gradebook. Added Tom with GPA 3.3.");
            }

            // Task 5: Calculate average GPA
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"\nAverage GPA: {averageGPA:F2}");

            // Task 6: Print students with GPA above average
            Console.WriteLine("\nStudents with GPA greater than average:");
            foreach (Student student in Student.studentList)
            {
                string name = student.GetName();
                if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
                {
                    student.PrintInfo();
                    Console.WriteLine($"GPA: {gradebook[name]}\n");
                }
            }
        }
    }
}
