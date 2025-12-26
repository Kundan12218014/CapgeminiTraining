// using System;
// public class Emplyee
// {
//   protected int Eid,Eage;
//   protected string Ename,Eaddress;
//   protected float Salary;
//   public virtual void GetEmployeeData()
//   {
//     Console.WriteLine("Enter Emplyee Detail");
//     Console.WriteLine("Enter the Id");
//     Eid=int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the Name");
//     Ename=Console.ReadLine();
//     Console.WriteLine("Enter the Address");
//     Eaddress=Console.ReadLine();
//     Console.WriteLine("Enter the Age");
//     Eage=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter the Salay");
//     Salary=Convert.ToSingle(Console.ReadLine());
//   }

//   public virtual void DisplayEmployeeData()
//   {
//     Console.WriteLine("\nEmployee Detais are ");
//     Console.WriteLine($"Employee Id Are: {Eid}");
//     Console.WriteLine($"Employee Name Are: {Ename}");
//     Console.WriteLine($"Employee Address Are: {Eaddress}");
//     Console.WriteLine($"Employee Age Are: {Eage}");
//     Console.WriteLine($"Employee Salary Are: {Salary}");
//   }
//   public virtual void CalculateSalary()
//   {
//     Console.WriteLine("Salay is {0}",Salary);
//   }
// }