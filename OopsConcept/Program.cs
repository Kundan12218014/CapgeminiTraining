using System;
using EmplyeeNamespace;
using CalculatorNamespace;
using VehicleNamespace;

namespace ProgramNamespace
{
  class Program
  {
    static void Main()
    {
      // Employee employee = new Employee
      // {
      //   EmployeeId = 101,
      //   Name = "John cena",
      //   Salary = 500000D
      // };

      // Calculator calculator=new Calculator();
      // Console.WriteLine($"{employee}");
      // calculator.Add(12, 23);
      // calculator.Add(2);

      // double distance=50.00;
      // double hour=5.0;
      // double fuel=10.0;
      // Vehicle vehicle=new Vehicle(distance,hour,fuel);//creating object of base calss
      // vehicle.Average();//calling base Class Member method;
      // vehicle.Speed();

      // Car car = new Car(distance,hour,fuel);
      // car.Average();
      // car.Speed();

      // Furniture f2=new Furniture();//error
      // Furniture f1=new Bookshelve();
      // f1.Accept();
      // f1.Display();

      Furniture f2=new Chair();
      f2.Accept();
      f2.Display();

    }
  }
}