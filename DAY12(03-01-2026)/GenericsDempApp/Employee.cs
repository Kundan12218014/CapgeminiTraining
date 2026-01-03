using System;
class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public override string ToString()
  {
    return $"Id is : {Id} Name is : {Name}";
  }
}