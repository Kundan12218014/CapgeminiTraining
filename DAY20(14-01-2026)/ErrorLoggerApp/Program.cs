using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
namespace ErrorLoggerApp
{

  public class Program
  {
    private static string filePath = "error_log.txt";
    public static void Main()
    {
      int choice;
      do
      {
        System.Console.WriteLine("Application Error Logger");
        System.Console.WriteLine("1. Log Error");
        System.Console.WriteLine("2. View All Error");
        System.Console.WriteLine("3. Clear All Error");
        System.Console.WriteLine("4. Exit");
        if (int.TryParse(Console.ReadLine(), out choice))
        {
          switch (choice)
          {
            case 1:
              LogError();
              break;
            case 2:
              ViewLog();
              break;
            case 3:
              DeleteLog();
              break;
            case 4:
              System.Console.WriteLine("Ending...");
              break;
            default:
              System.Console.WriteLine("Invalid Choice.");
              break;
          }
        }
      } while (choice != 4);
    }
    static void LogError()
    {
      try
      {
        System.Console.Write("Enter the Log: ");
        string message = Console.ReadLine();
        string logEntry = $"{DateTime.Now:MM/dd/yyyy} : {message}{Environment.NewLine}";
        File.AppendAllText(filePath, logEntry);
        System.Console.WriteLine("Error Logged Successfully.");
      }
      catch (UnauthorizedAccessException ex)
      {
        System.Console.WriteLine($"Ex: {ex.Message}");
      }
      catch (Exception ex)
      {
        System.Console.WriteLine($"Ex: {ex.Message}");
      }
    }
    static void ViewLog()
    {
      try
      {

        if (File.Exists(filePath))
        {
          string LogEntry = File.ReadAllText(filePath);
          if (string.IsNullOrWhiteSpace(LogEntry))
          {
            System.Console.WriteLine("No Error Logged");
          }
          else
          {
            System.Console.WriteLine($"\nLogged Entries\n{LogEntry}");
          }
        }
        else
        {
          System.Console.WriteLine("No LogError Exits");
        }

      }
      catch (UnauthorizedAccessException ex)
      {
        System.Console.WriteLine($"Ex: {ex.Message}");
      }
      catch (Exception ex)
      {
        System.Console.WriteLine($"Ex: {ex.Message}");
      }
    }
    static void DeleteLog()
    {
      try
      {
        if (File.Exists(filePath))
        {
          File.Delete(filePath);
          System.Console.WriteLine("Log Cleared Successfully.");
        }
        else
        {
          System.Console.WriteLine("Log Does not Exists");
        }
      }
      catch (Exception ex)
      {
        System.Console.WriteLine("Ex: " + ex.Message);
      }
    }
  }

}