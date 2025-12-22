using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
class Program
{
  public static void Main(String []args)
  {
    //calling a default constructor
    Calculator cal1=new Calculator();
    int number1=20;
    int number2=10;
    // Console.WriteLine($"The Additon of {number1} and {number2}");
    // Console.WriteLine(cal1.Add(number1,number2));
    // Console.WriteLine(cal1.Subtract(number1,number2));

    cal1.Multiply(number1,number2);

    //calling prametrized constuctor
    // Calculator cal2=new Calculator(number1,number2);
    // cal2.Divide();

    //pass by val
    Console.WriteLine($"Call by value {number1} and {number2}");
    cal1.SwapByValue(number1,number2);
    Console.WriteLine($"Call by value {number1} and {number2}");
    //call by ref
    Console.WriteLine($"Call by ref before {number1} and {number2}");
    cal1.SwapByRef(ref number1,ref number2);
    Console.WriteLine($"Call by ref after {number1} and {number2}");


    Calculator cal3=new Calculator();
    int number3, number4, result;
    cal3.Additon(number1,number2,out number3,out number4,out result);
    Console.WriteLine($"Value of the number1 is {number1} , number 2 is {number2} , number 3 is {number3} , number4 is {number4},result is {result}");

  }
}