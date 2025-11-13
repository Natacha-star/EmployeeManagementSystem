namespace WorkReviewTest;

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string firstname, string lastname, double salary):base (id , firstname , lastname, salary)

    {
        
    }
    public override double CalculateNetSalary()
    {
        return Salary * 0.8;
    }

    public override void GeneratePaySlip()
    {
        Console.WriteLine($"names are{FirstName} {LastName} and earns{CalculateSalary()}");
    }
}