using System;
using System.Linq;

namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
        // Creating Customer objects
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Calling methods
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    // Q1: Calculate and print the total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = customer_list.Sum(c => c.CustomerCredit);
        Console.WriteLine($"Q1: Total Credit: {totalCredit}");
    }

    // Q2: Calculate and print the average age of customers living in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.CustomerCity == "Amarillo");
        double averageAge = amarilloCustomers.Average(c => c.CustomerAge);
        Console.WriteLine($"Q2: Average Age of Amarillo Customers: {averageAge:F2}");
    }

    // Q3: Print the names of customers who live in Canyon and are older than 30, separated by commas
    public static void CanyonAge(Customer[] customer_list)
    {
        string names = string.Join(", ", customer_list.Where(c => c.CustomerCity == "Canyon" && c.CustomerAge > 30).Select(c => c.CustomerName));
        Console.WriteLine($"Q3: Customers in Canyon older than 30: {names}" );
    }
}

// Q0: Customer class definition
class Customer
{
    public string CustomerName { get; }
    public int CustomerAge { get; }
    public string CustomerCity { get; }
    public double CustomerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}
