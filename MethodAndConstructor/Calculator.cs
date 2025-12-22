using System;
using System.IO.Pipelines;
class Calculator
{
  // private int num1;
  // public int Num1
  // {
  //   get
  //   {
  //     return num1;
  //   }
  //   set
  //   {
  //     num1=value;
  //   }
  // }

  //auto-implemented property
  public int Number1{get;set;}
  public int Number2{get;set;}
  public int Result{get;set;}
  public Calculator(){
    Number1=0;
    Number2=0;
    Result=0;
  }
  public Calculator(int number1,int number2)
  {
    this.Number1=number1;
    this.Number2=number2;
  }

  //Method with Parameter with return type
  public int Add(int number1,int number2)
  {
    Number1=number1;
    Number2=number2;
    Result=Number1+Number2;
    return Result;
  }
  public int Subtract(int number1,int number2)
  {
    Number1=number1;
    Number2=number2;
    Result=Number1-Number2;
    return Result;
  }

  public void Multiply(int number1,int number2)
  {
    int Result= number1*number2;
    Console.WriteLine($"Multiplication of number is {Result}"); 
  }
  //Method without parameter without return type
  public void Divide()
  {
    Result=Number1/Number2;
    Console.WriteLine($"Division of {Number1} and {Number2} is {Result}");
  }
  public void Additon(int number1,int number2,out int number3,out int number4,out int result)
  {
    number3=number1;
    number4=number2;
    result=number1+number2;
  }
  public void SwapByValue(int num1,int num2)
  {
    int temp=num1;
    num1=num2;
    num2=temp;
  }
  public void SwapByRef(ref int num3,ref int num4)
  {
    num3=num3^num4;
    num4=num3^num4;
    num3=num3^num4;
  }
}