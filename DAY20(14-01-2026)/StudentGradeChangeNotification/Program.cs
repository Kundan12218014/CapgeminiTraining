using System;
namespace StudentGradeChangeNotificationApp
{
  public class Program
  {
    public static void Main()
    {
      Student student = new Student();
      student.GradeChanged += (newGrade) =>
      {
        System.Console.WriteLine($"Grade Changed to {newGrade}");
      };
      if (int.TryParse(Console.ReadLine(), out int grade))
      {
        student.UpdateGrade(grade);
      }
      else
      {
        System.Console.WriteLine("Invalid grade");
      }
    }
  }
  public class Student
  {
    public event Action<int> GradeChanged;
    public void UpdateGrade(int grade)
    {
      GradeChanged?.Invoke(grade);
    }
  }
}