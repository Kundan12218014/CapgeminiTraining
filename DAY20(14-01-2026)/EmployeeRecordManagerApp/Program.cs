using System;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;
namespace EmployeeRecordManagerApp
{
  public class Program
  {
    private static string filePath = "employees.json";
    public static void Main()
    {
      List<Employee> employees = LoadEmployee();
      int choice;
      do
      {
        Console.WriteLine("\n1. Add Employee\n2. View Employees\n3. Save & Exit");
        int.TryParse(Console.ReadLine(), out choice);
        switch (choice)
        {
          case 1:
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();
            employees.Add(new Employee { Id = id, Name = name, Department = dept });
            break;
          case 2:
            if (employees.Count == 0) { System.Console.WriteLine("No Record Found"); }
            employees.ForEach(e => System.Console.WriteLine($"{e.Id} - {e.Name} - {e.Department}"));
            break;
          case 3:
            SaveEmployees(employees);
            break;
          default:
            System.Console.WriteLine("Invalid Choice.");
            break;
        }
      } while (choice != 3);
    }
    public static List<Employee> LoadEmployee()
    {
      try
      {
        if (!File.Exists(filePath))
        {
          System.Console.WriteLine("JSON file created");
          return new List<Employee>();
        }
        System.Console.WriteLine("Data loaded from file");
        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
      }
      catch (JsonException)
      {
        System.Console.WriteLine("Warning Employee Data File is Corrupted . Start with empty list.");
        return new List<Employee>();
      }
    }

    public static void SaveEmployees(List<Employee> empList)
    {
      string jsonString = JsonSerializer.Serialize(empList, new JsonSerializerOptions { WriteIndented = true });
      File.WriteAllText(filePath, jsonString);
    }
  }
  public class Employee
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
  }

}