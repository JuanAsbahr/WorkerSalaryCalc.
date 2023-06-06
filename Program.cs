using System;
using System.Globalization;
using WorkerSalary.Entities;
using WorkerSalary.Entities.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("#  Enter worker data  #");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Departament dept = new Departament(deptName);
        Worker worker = new Worker(name, level, basesalary, dept);

        Console.Write("How many contracts to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Enter #{i} contract data");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date,valuePerHour,hours);
           
            worker.AddContract(contract);
        }
        Console.WriteLine();
        Console.Write("Enter mouth and year to calculate income (MM/YYYY): ");
        string mouthandyear = Console.ReadLine();

        int mouth = int.Parse(mouthandyear.Substring(0, 2));
        int year = int.Parse(mouthandyear.Substring(3));

        Console.WriteLine();
        Console.WriteLine("Name: " + worker.Name + ".");
        Console.WriteLine("Departament: " + worker.Departament.Name + ".");
        Console.WriteLine("Income for " + mouthandyear + ": $" + worker.Income(year, mouth).ToString("F2", CultureInfo.InvariantCulture));

    }
}