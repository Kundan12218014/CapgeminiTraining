using System;
namespace EmplyeeNamespace
{
  public class Employee
  {
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(int EmployeeId, string Name, double Salary)
    {
      this.EmployeeId = EmployeeId;
      this.Name = Name;
      this.Salary = Salary;
    }
    public Employee()
    {
      EmployeeId=101;
      Name="Kudnan Kumar";
      Salary=5002345D;
    }

    //overRiding
    public override string ToString()
    {
      return $"Emplyee Detaills are :\n Employee Id is {EmployeeId}\n Name is : {Name} Salary is : {Salary}";
    }
    
  }
}