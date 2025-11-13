namespace WorkReviewTest;

public interface IEmployee
{
    void GeneratePaySlip();
    double CalculateNetSalary();

}

public abstract class Employee: IEmployee
    {
        public int EmployeeId { get; set; } // (Auto-property)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private double _salary;

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary must be >= 0");
                }
                _salary = value;
            }
        }

        public Employee(int id, string firstname, string lastname, double salary)
        {
            EmployeeId = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
        }
        public abstract double CalculateSalary();
        public abstract void GeneratePaySlip();
    }
   
        
        
    
