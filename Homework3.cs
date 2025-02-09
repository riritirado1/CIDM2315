namespace Homework3;
class Program
{
    static void Main(string[ ] args)
    {
        // Code for Q1

        Console.WriteLine("Input an integer:");
        string str_num1 = Console.ReadLine();
        int number1 = Convert.ToInt16(str_num1);
        bool isPrime = true;
        
        if (number1 < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < number1; i++)
            {
                if (number1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        };
        
        if (isPrime)
            Console.WriteLine($"{number1} is a prime number.");
        else
            Console.WriteLine($"{number1} is not a prime number.");

        // Code for Q2

        Console.WriteLine("Input an integer:");
        string str_num2 = Console.ReadLine();
        int number2 = Convert.ToInt16(str_num2);

        for(int row = 0; row < number2; row++)
        {
            for(int col = 0; col < number2; col++)
            {
            Console.Write("#");
            }
            Console.WriteLine("");
        };

        // Code for Q3

        Console.WriteLine("Input an integer:");
        string str_num3 = Console.ReadLine();
        int number3 = Convert.ToInt16(str_num3);

        for(int row = 0; row < number3; row++)
        {
            for(int col = 0; col < number3; col++)
            {
                if(row >= col)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        };

        // Code for Bonus Question

        Console.Write("Enter a number: ");
        string str_num4 = Console.ReadLine();
        int number4 = Convert.ToInt16(str_num4);
        
        for (int i = 1; i <= number4; i++)
        {
            for (int j = 1; j <= number4 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

    }
}
