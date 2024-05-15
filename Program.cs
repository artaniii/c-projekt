
using System;

class ArrayMin
{
    public static int Min(int[] array)
    {
        int min = array[0];
        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public virtual double CalculateBonus(double salary)
    {
        return 1000; // bonusi fiks
    }
}

class Developer : Employee
{
    public override double CalculateBonus(double salary)
    {
        double percentageBonus = salary * 0.2; // 20% e pagës
        return Math.Max(1000, percentageBonus);
    }
}

class Manager : Employee
{
    public override double CalculateBonus(double salary)
    {
        double percentageBonus = salary * 0.25; // 25% e pagës
        return Math.Max(1000, percentageBonus);
    }
}

class Admin : Employee
{
    // nuk ka nevojë për override, mbetet bonusi fiks
}

class Program
{
    static void Main(string[] args)
    {
        // Testimi i gjetjes së vlerës minimale në një array
        Console.WriteLine("Shkruani madhësinë e array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Shkruani elementet e array:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int min = ArrayMin.Min(numbers);
        Console.WriteLine("Vlera minimale në array është: " + min);

        // Testimi i llogaritjes së bonusit për punonjësit
        Developer dev = new Developer { Id = 1, Name = "John", Position = "Developer", Salary = 60000 };
        Manager mgr = new Manager { Id = 2, Name = "Alice", Position = "Manager", Salary = 70000 };
        Admin admin = new Admin { Id = 3, Name = "Bob", Position = "Admin", Salary = 55000 };

        Console.WriteLine("\nPunonjësit dhe bonuset e tyre:");
        Console.WriteLine("Developer: {0}, Bonus: {1}", dev.Name, dev.CalculateBonus(dev.Salary));
        Console.WriteLine("Manager: {0}, Bonus: {1}", mgr.Name, mgr.CalculateBonus(mgr.Salary));
        Console.WriteLine("Admin: {0}, Bonus: {1}", admin.Name, admin.CalculateBonus(admin.Salary));
    }
}