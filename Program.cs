using System;
using System.Globalization;
using WorkerSalary.Entities.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



    }
}