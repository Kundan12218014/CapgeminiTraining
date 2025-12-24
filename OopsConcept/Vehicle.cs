using System;
namespace VehicleNamespace

{
  public class Vehicle
  {
    public double Distance { get; set; } 
    public double Hour { get; set; }
    public double Fuel {get;set;}

    internal Vehicle(double Distance,double Hour,double Fuel)
    {
      this.Distance=Distance;
      this.Hour=Hour;
      this.Fuel=Fuel;
    }
    public void Average()
    {
      double average=0.0;
      average=Distance/Fuel;
      Console.WriteLine($"Vehical Average is {0:0.00}");
    }
    public virtual void Speed()
    {
      double speed=Distance/Hour;
      Console.WriteLine($"Speed is : {speed}");
      return ;
    }
  }
}