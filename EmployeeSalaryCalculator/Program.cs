using System;
namespace EmployeeSalaryCalculator
{
  public class Employee
  {
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public virtual double CalculateSalary()
    {
      return HourlyRate * HoursWorked;
    }
  }
  public class FullTimeEmployee : Employee
  {
    public override double CalculateSalary()
    {
      return HourlyRate * HoursWorked;
    }
  }
  public class PartTimeEmployee : Employee
  {
    public override double CalculateSalary()
    {
      return HourlyRate * 0.80 * HoursWorked;
    }
  }
  public class Intern : Employee
  {
    public override double CalculateSalary()
    {
      return HourlyRate * 0.60 * HoursWorked;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the value of n");
      string nInput = Console.ReadLine();
      if (!int.TryParse(nInput, out int n) || n <= 0)
      {
        Console.WriteLine("Please enter a valid positive integer.");
        return;
      }

      Employee[] employees = new Employee[n];

      for (int i = 0; i < n; i++)
      {
        Employee emp = null;
        while (emp == null)
        {
          
          string typeInput = Console.ReadLine();
          if (string.IsNullOrEmpty(typeInput)) continue;

          if (typeInput.Equals("fulltimeemployee", StringComparison.OrdinalIgnoreCase))
          {
            emp = new FullTimeEmployee();
          }
          else if (typeInput.Equals("parttimeemployee", StringComparison.OrdinalIgnoreCase))
          {
            emp = new PartTimeEmployee();
          }
          else if (typeInput.Equals("intern", StringComparison.OrdinalIgnoreCase))
          {
            emp = new Intern();
          }
          else
          {
            Console.WriteLine("Unknown employee type. Please enter FullTimeEmployee, PartTimeEmployee, or Intern.");
            continue;
          }

          bool validRate = false;
          while (!validRate)
          {
            string rateInput = Console.ReadLine();
            if (double.TryParse(rateInput, out double rate))
            {
              emp.HourlyRate = rate;
              validRate = true;
            }
            else
            {
              Console.WriteLine("Invalid input for hourly rate. Please enter a numeric value.");
            }
          }

          bool validHours = false;
          while (!validHours)
          {
            string hoursInput = Console.ReadLine();
            if (double.TryParse(hoursInput, out double hours))
            {
              emp.HoursWorked = hours;
              validHours = true;
            }
            else
            {
              Console.WriteLine("Invalid input for hours worked. Please enter a numeric value.");
            }
          }
        }
        employees[i] = emp;
      }

      Console.WriteLine("Salaries of the employees:");
      for (int i = 0; i < n; i++)
      {
        Console.WriteLine($"Salary of Employee {i + 1} ({employees[i].GetType().Name}): {employees[i].CalculateSalary()}");
      }
    }
  }
}