using System;
using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
internal class Program
{
    public static void PrintClient(Clients client)
    {
        Console.WriteLine($"Customer ID: {client.CustomerId}");
        Console.WriteLine($"Name: {client.Name}");
        Console.WriteLine($"Address: {client.Address}");
        Console.WriteLine($"Phone Number: {client.PhoneNumber}");
    }

    public static void PrintAccount(Accounts account)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance}");
        Console.WriteLine($"Account Type: {account.AccountType}");
    }

    public static void PrintEmployee(Employees employee)
    {
        Console.WriteLine($"Employee ID: {employee.EmployeeId}");
        Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Position: {employee.Position}");
        Console.WriteLine($"Salary: {employee.Salary}");
    }

    static void Main(string[] args)
    {
        //? Create a new client, account, and employee
        Clients customer1 = new Clients { CustomerId = 1, Name = "Mohamed", Address = "123 St", PhoneNumber = "123456789" };
        Accounts account1 = new Accounts { AccountNumber = 1, Balance = 1000, AccountType = "Savings" };
        Employees employee1 = new Employees { EmployeeId = 1, FirstName = "Ahmed", LastName = "Ali", Position = "Manager", Salary = 100000 };

        //? Print the client, account, and employee
        PrintClient(customer1);
        PrintAccount(account1);
        PrintEmployee(employee1);
    }
}