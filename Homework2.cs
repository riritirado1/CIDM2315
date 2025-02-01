namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        
        Console.WriteLine("Please input a letter grade: ");
        string letter_grade = Console.ReadLine();
        switch(letter_grade)
        {
            case "A":
                Console.WriteLine("GPA Point: 4");
                break;
            case "B":
                Console.WriteLine("GPA Point: 3");
                break;
            case "C":
                Console.WriteLine("GPA Point: 2");
                break;
            case "D":
                Console.WriteLine("GPA Point: 1");
                break;
            case "F":
                Console.WriteLine("GPA Point: 0");
                break;
            // To let users input small letters, and it will not be mistakenly tagged as invalid letter grade
            case "a":
                Console.WriteLine("GPA Point: 4");
                break;
            case "b":
                Console.WriteLine("GPA Point: 3");
                break;
            case "c":
                Console.WriteLine("GPA Point: 2");
                break;
            case "d":
                Console.WriteLine("GPA Point: 1");
                break;
            case "f":
                Console.WriteLine("GPA Point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        };

        //Code for Q2

        Console.WriteLine("Please input the first number: ");
        string first_num = Console.ReadLine();
        int int_num1 = Convert.ToInt16(first_num);
        Console.WriteLine("Please input the second number: ");
        string second_num = Console.ReadLine();
        int int_num2 = Convert.ToInt16(second_num);
        Console.WriteLine("Please input the third number: ");
        string third_num = Console.ReadLine();
        int int_num3 = Convert.ToInt16(third_num);

        if(int_num1 <= int_num2) 
        {
            if(int_num1 <= int_num3)
            {
                Console.WriteLine($"The smallest value is: {int_num1}");
            }
            else
            {
                Console.WriteLine($"The smallest value is: {int_num3}");
            };
        }
        else
        {
            if(int_num2 <= int_num3)
            {
                Console.WriteLine($"The smallest value is: {int_num2}");
            }
            else
            {
                Console.WriteLine($"The smallest value is: {int_num3}");
            };
        };

        //Code for Bonus question

        Console.WriteLine("Please input a year: ");
        string year = Console.ReadLine();
        int int_year = Convert.ToInt16(year);
        int rem = int_year%4; //Leap years are divisible by 4, so getting the remainder is the best indicator if a year is a leap year or not

        switch(rem)
        {
            case 0://Since leap years are divisible by 4, then the remainder is 0
                Console.WriteLine($"{int_year} is a leap year."); 
                break;
            default:
                Console.WriteLine($"{int_year} is not a leap year.");
                break;
        };
    }
}
