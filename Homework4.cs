namespace Homework4;
class Program
{
    static void Main(string[ ] args)
    	{
       // Call Q1_method()
       Console.WriteLine("Enter first number: ");
       int number_1 = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Enter second number: ");
       int number_2 = Convert.ToInt16(Console.ReadLine());
       Console.WriteLine($"The largest number is: {LargestNum(number_1,number_2)}");

       // Call Q2_method()
        Console.Write("Enter the number of rows (N): ");
        int N = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter the shape (left or right): ");
        string shape = Console.ReadLine();

        PrintTriangle(N, shape);
}


// Q1_method
    static int LargestNum(int num1, int num2) {
        return (num1 > num2) ? num1 : num2;
    }

 //Q2_method
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}, Shape: {shape}");
        
        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");
        }
    }
}
