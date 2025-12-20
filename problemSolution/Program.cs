using System;
namespace ProblemSolution
{
  class Problem
  {
    static void Main(String [] args)
    {
      // Problem leap=new Problem();
      // leap.CalculateLeapYear();  

      // Problem sumUpN=new Problem();
      // sumUpN.SumOfNNaturalNumber();

      Problem temperature =new Problem();
      // temperature.CelciusToFahrenheit();
      temperature.FahrenheitToCelsius();

      

    }
    public void CalculateLeapYear()
    {
      int year=Convert.ToInt32(Console.ReadLine());
      if (year % 4 == 0 && year % 100 == 0|| year % 400 == 0)
      {
        Console.WriteLine("Year is leap year");
      }
      else
      {
        Console.WriteLine("Year is Non Leap Year");
      }
    }
    public void SumOfNNaturalNumber()
    {
      Console.WriteLine("Enter the value of N: ");

      int n=Convert.ToInt32(Console.ReadLine());
      int sum=n*(n+1)/2;
      Console.WriteLine("Sum is : {0}",sum);
    }
    public void CelciusToFahrenheit()
    {
      Console.WriteLine("Enter the value of Temperature in Celsius: ");
      int celsius=Convert.ToInt32(Console.ReadLine());
      int fahrenheit=(celsius*9/5)+32;
      Console.WriteLine("Temperature in celcius : {0}",celsius);
      Console.WriteLine("Temperature in Fahrenheit: {0}",fahrenheit);
    }
    public void FahrenheitToCelsius()
    {
      Console.WriteLine("Enter the value of Temperature in Celsius: ");
      int fahrenheit =Convert.ToInt32(Console.ReadLine());
      int celsius=(fahrenheit-32)*5/9;
      Console.WriteLine("Temperature in Fahrenheit: {0}",fahrenheit);
      Console.WriteLine("Temperature in celcius : {0}",celsius);
    }
  }
}