using System;
using System.IO;
using Microsoft.Win32.SafeHandles;
namespace StudentLoggerNamespace
{
  public class StudentLogger
  {
    private const string filePath = "attendance.txt";
    public static void WriteToFile(string data)
    {
      // string filePath = @"attendance.txt";
      try
      {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
          streamWriter.WriteLine(data);
          streamWriter.Flush();
          streamWriter.Close();
          fileStream.Close();
        }
      }
      catch (UnauthorizedAccessException ioEx)
      {
        System.Console.WriteLine("Error: You do have permission to access the file.");
      }
      catch (IOException ex)
      {
        System.Console.WriteLine("I/O Error :", ex.Message);
      }
      catch (Exception ex)
      {
        System.Console.WriteLine("Unexpected Error : ", ex.Message);
      }
    }
    public static void AddStudentAttendance()
    {
      System.Console.WriteLine("Enter the StudentId : ");
      int.TryParse(Console.ReadLine(), out int studentId);
      System.Console.WriteLine("Enter the Student Name: ");
      string studentName = Console.ReadLine();
      System.Console.WriteLine("Enter status (present/absent)");
      string status = Console.ReadLine();
      string LogEntry = $"{DateTime.Now.ToShortDateString()} | {studentId} | {studentName} | {status}";
      WriteToFile(LogEntry);

    }

    // public static void ViewStudentAttendance()
    // {
    //   if (!File.Exists(filePath))
    //   {
    //     Console.WriteLine("No records found.");
    //     return;
    //   }
    //   Console.WriteLine("\n--- Attendance Records ---");
    //   System.Console.WriteLine("Date | StudentId | Name | Status");
    //   Console.WriteLine(File.ReadAllText(filePath));
    // }
    public static void ViewStudentAttendance()
    {
      if (!File.Exists(filePath))
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n[!] No records found.");
        Console.ResetColor();
        return;
      }

      Console.WriteLine("\n" + new string('=', 60));
      Console.ForegroundColor = ConsoleColor.Cyan;

      // Header with fixed widths: Date(12), ID(10), Name(20), Status(10)
      Console.WriteLine("{0,-12} | {1,-10} | {2,-20} | {3,-10}", "DATE", "ID", "NAME", "STATUS");
      Console.WriteLine(new string('-', 60));
      Console.ResetColor();

      string[] records = File.ReadAllLines(filePath);
      foreach (string record in records)
      {
        string[] parts = record.Split('|');
        if (parts.Length == 4)
        {
          // Trim to remove any accidental extra spaces
          Console.WriteLine("{0,-12} | {1,-10} | {2,-20} | {3,-10}",
              parts[0].Trim(), parts[1].Trim(), parts[2].Trim(), parts[3].Trim());
        }
      }
      Console.WriteLine(new string('=', 60) + "\n");
    }

    public static void Main()
    {
      while (true)
      {
        System.Console.WriteLine("Enter the Choice: ");
        System.Console.WriteLine("1. Add Attentance Records.");
        System.Console.WriteLine("2. View Attentance Records.");
        System.Console.WriteLine("3. Exit.");
        int.TryParse(Console.ReadLine(), out int choice);
        switch (choice)
        {
          case 1:
            AddStudentAttendance();
            break;
          case 2:
            ViewStudentAttendance();
            break;
          case 3:
            System.Console.WriteLine("Ending...");
            return;
          default:
            System.Console.WriteLine("Invalid Choice .please Enter correct options");
            break;
        }
      }
    }
  }
}