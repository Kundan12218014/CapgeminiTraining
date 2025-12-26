using System;
namespace PartialNamespace
{
  public partial class PartialEmployee
  {
    public void DisplayFullName()
  {
    Console.WriteLine("Full Name is : {0} {1}",_firstName,_lastName);
  }
  public void DisplayEmployeeDetails()
  {
    Console.WriteLine("Employee Details : ");
    Console.WriteLine("First Name : {0}",_firstName);
    Console.WriteLine("Last Name : {0}",_lastName);
    Console.WriteLine("Gender Details {0}",_gender);
    Console.WriteLine("Salary Details :{0}",_salary);
  }
  public partial void PartialMethod()
    {
      Console.WriteLine("Partail Method Invoked");
    }
}
}