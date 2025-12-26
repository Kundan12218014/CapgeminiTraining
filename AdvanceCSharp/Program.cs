using System;
using System.Diagnostics;
using System.Reflection.Emit;
namespace PartialNamespace
{
  class Program
  {
    public delegate int CalculatorDelegate(int num1, int num2);
    public static void Main()
    {
      // PartialEmployee part=new PartialEmployee();
      // part.FirstName="Kundan";
      // part.LastName="Kumar";
      // part.Gender="male";
      // part.Salary=123456D;
      // part.DisplayEmployeeDetails();
      // part.DisplayFullName();
      // part.PartialMethod();


      //calculator object
      Calculator cal = new Calculator();

      //1.initilizing the Delegate
      CalculatorDelegate calAdd = new CalculatorDelegate(cal.Add);
      CalculatorDelegate calSub = new CalculatorDelegate(cal.Subtract);
      CalculatorDelegate calMul = new CalculatorDelegate(cal.Multiply);
      CalculatorDelegate calDiv = new CalculatorDelegate(cal.Divide);
      //calling single cast Delegate
      int sum = calAdd(20, 30);
      Console.WriteLine($"addition {sum}");
      int diff = calSub(20, 30);
      Console.WriteLine($"diffrence {diff}");
      int mul = calMul(20, 30);
      Console.WriteLine($"multiplicaton {mul}");
      int div = calDiv(20, 30);
      Console.WriteLine($"division {div}");



      // Console.WriteLine("\nMulticast Delegate");
      // CalculatorDelegate multiDeligate = cal.Add;
      // multiDeligate += cal.Subtract;
      // multiDeligate += cal.Multiply;
      // multiDeligate += cal.Divide;

      // // Invoke the multicast delegate
      // Console.WriteLine("Invoking multiDeligate (Add, Subtract, Multiply, Divide):");
      // multiDeligate(10, 5);

      // // Remove a delegate from the multicast chain
      // Console.WriteLine("\nRemoving Subtract from multiDeligate...");
      // multiDeligate -= cal.Subtract;

      // // Invoke again after removal
      // Console.WriteLine("Invoking multiDeligate (Add, Multiply, Divide) after removing Subtract:");
      // multiDeligate(10, 5);



    }
  }
}