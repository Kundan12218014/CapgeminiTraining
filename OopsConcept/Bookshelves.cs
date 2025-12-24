using System;

class Bookshelve : Furniture
{
  public override void Accept()
  {
    Console.WriteLine("Enter number of shelves");
    num=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Color");
    color=Convert.ToString(Console.ReadLine());
    Console.WriteLine("Enter the Width");
    width=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Height");
    height=Convert.ToInt32(Console.ReadLine());

  }
  public override void Display()
  {
    Console.WriteLine($"The Numer of Shelves: {num}");
    Console.WriteLine($"The  color of Shelves: {color}");
    Console.WriteLine($"The width of Shelves: {width}");
    Console.WriteLine($"The height of Shelves: {height}");
  }
}