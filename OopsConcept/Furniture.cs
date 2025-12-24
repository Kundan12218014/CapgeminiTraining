using System;
using System.Diagnostics;
public abstract class Furniture
{
  protected int num;
  protected string color;
  protected int width;
  protected int height;
  public abstract void Accept();
  public abstract void Display();
  public void MyMethod()
  {
    Console.WriteLine("Mymethod");
  }

}