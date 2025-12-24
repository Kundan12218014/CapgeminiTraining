using System;
namespace CalculatorNamespace
{
  public class Calculator
  {

    // public void Add(int number1, int number2)
    // {
    //   Console.WriteLine("Normal Add: ");
    //   Console.WriteLine($"Sum: {number1 + number2}");
    // }
    public void Add(params int[] arr)
    {
      Console.WriteLine("Params Add: ");
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        sum += arr[i];
      }
      Console.WriteLine($"Sum is : {sum}");
    }
    public int  Add()
    {
      return 0;
    }
    public int Add(int number2)
    {
      int num1=20;
      int num2=number2;
      return num1+num2;
    }
    public int Add(int n1,int n2)
    {
      return n1+n2;
    }
    public int Add(string str1,string str2)
    {
      Console.WriteLine($"Concatened String : {str1+str2}");
      return 0;
    }
    public int Add(string str1,float flt,int num)
    {
      Console.WriteLine($"String {str1} float is {flt} int {num}");
      return 0;
    }
  }
}