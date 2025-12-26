// using System;
// public sealed class Manager : Employee
// {
//   double Bonus,CA;
//   public override void GetEmployeeData()
//   {
//     Console.WriteLine("Enter the Manager Detail");
//     Console.WriteLine("Enter the id");
//     Eid=int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the Name");
//     Ename=int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the Bonus");
//     Bonus=double.Parse(Console.ReadLine());
//     Console.WriteLine("Enter the CA");
//     CA=Convert.ToDouble(Console.ReadLine());
//   }
//     public virtual void DisplayEmployeeData()
//   {
//     Console.WriteLine("\nMANAGER Detais are ");
//     Console.WriteLine($"Employee Id Are: {Eid}");
//     Console.WriteLine($"Employee Name Are: {Ename}");
//     Console.WriteLine($"Employee Bonus Are: {Bonus}");
//     Console.WriteLine($"Employee CA Are: {CA}");
//   }
//   public override void CalculateSalary()
//   {
//     Console.WriteLine($"Manager Salary is : {Salary}");
//   }
// }