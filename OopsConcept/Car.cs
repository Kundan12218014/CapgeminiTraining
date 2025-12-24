using System;
namespace VehicleNamespace
{
  public class Car : Vehicle
  {
    public Car(double Distance, double Hour, double Fuel) : base(Distance, Hour, Fuel)
    {

    }
    public new void Average()
    {
      // double average=0.00;
      // double Hour=5.0;
      // double fuel=10.0;

      Console.WriteLine($"Average Fuel : {Distance / Fuel}");
    }
    public override void Speed()
    {
      double speed = Distance / Hour;
      Console.WriteLine($"Speed is : {speed}");
    }

  }
}