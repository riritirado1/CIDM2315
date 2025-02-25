namespace Homework5;

class NumberHelper
{
    //Q1
    public static void GetLargestNumber(int num1, int num2, out int largest)
    {
        largest = (num1 > num2) ? num1 : num2;
    }
    //Q2
    public static void GetLargestOfFour(int num3, int num4, int num5, int num6, out int largest)
    {
        GetLargestNumber(num3, num4, out int temp1);
        GetLargestNumber(num5, num6, out int temp2);
        GetLargestNumber(temp1, temp2, out largest);
    }
}

class AccountHelper
{
    //Q3
    public static bool CheckAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >= 18;
    }

    public static void CreateAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter password: ");
        string password = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter password again: ");
        string confirmPassword = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter birth year: ");
        if (!int.TryParse(Console.ReadLine(), out int birthYear))
        {
            Console.WriteLine("Invalid birth year input. Could not create an account.");
            return;
        }

        if (CheckAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account. Age must be 18 or older.");
        }
    }
}

class Program
{
 // Q1_method
  static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        NumberHelper.GetLargestNumber(num1, num2, out int largest);
        Console.WriteLine($"The largest number is: {largest}");

 // Q2_method
        Console.Write("Enter first number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num4 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num5 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        int num6 = Convert.ToInt16(Console.ReadLine());

        NumberHelper.GetLargestOfFour(num3, num4, num5, num6, out int largestFour);
        Console.WriteLine($"The largest of the four numbers is: {largestFour}");
    
 // Q3_method
        Console.WriteLine("\nAccount Creation Process:");
        AccountHelper.CreateAccount();
    }
  }
