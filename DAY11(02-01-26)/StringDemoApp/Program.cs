using System.Text;
using System;
using System.Globalization;
using System.Collections;
namespace StringDemoNamespace
{
  public class Program
  {
    public static void Main()
    {
      // StringBuilder sb = new StringBuilder("Hello World");
      // for (int i = 0; i < sb.Length; i++)
      // {
      //   Console.Write(sb[i]);
      // }

      // StringBuilder sb1 = new StringBuilder();
      // sb1.AppendLine("Hello");
      // sb1.Append("Hello ");
      // sb1.AppendLine("World");
      // sb1.AppendLine("Hello C#");
      // Console.WriteLine(sb1);

      // StringBuilder sbAmount = new StringBuilder("Your Total Amount is : ");
      // sbAmount.AppendFormat("{0:C} ", 25);
      // CultureInfo india = new CultureInfo("en-IN");
      // sbAmount.AppendFormat(india, "{0:C} ", -123456);

      // Console.WriteLine(sbAmount);
      ArrayListDemo();

    }
    public static void  ArrayListDemo()
    {
      ArrayList list=new ArrayList();
      list.Add(10);
      list.Add(20);
      list.Add(30);
      list.Add(40);
      list.Add(50);
      list.Add(55.2f);
      list.Add(false);
      Console.WriteLine($"Count of Aray List is {list.Count}");
      // printList(list);

      Employee emp1=new Employee(){Id=10,Name="Kundan"};
      Employee emp2=new Employee(){Id=11,Name="Kunal"};
      Employee emp3=new Employee(){Id=12,Name="Kumar"};
      list.Add(emp1);
      list.Add(emp2);
      list.Add(emp3);
      // printList(list);

      ArrayList list1=new ArrayList();
      list1.Add(60);
      list1.Add(70);
      list1.Add(80);

      list.AddRange(list1);

      // printList(list);

      // Console.WriteLine($"Count of Aray List is {list.Count}");
      // // list.Clear();
      // Console.WriteLine($"Removing of Array List is {list.Count}");
      // if (list.Contains(50))
      // {
      //   Console.WriteLine($"found at index {list.IndexOf(50)}");
      // }
      // else
      // {
      //   Console.WriteLine("Not Found");
      // }

      // list.RemoveAt(5);
      // list.Reverse();
      // printList(list);


      // Console.WriteLine("list before insert: ");
      // printList(list);
      // list.Insert(0,90);

      // Console.WriteLine("list after before insert: ");
      // printList(list);

      // ArrayList list2=new ArrayList();
      // list2.Add(47);
      // list2.Add(46);
      // list2.Add(44);
      // list.InsertRange(5,list2);
      // printList(list);

      // Console.WriteLine("List after Removing value false form the list by value");
      // list.Remove(false);
      // printList(list);
      // Console.WriteLine("List after Removing value false form the list by index");
      // list.RemoveAt(6);
      // printList(list);
      // Console.WriteLine("List after Removing range form the list");
      // list.RemoveRange(5,3);
      // printList(list);

      list.Reverse();
      list.Sort();
      printList(list);
    }
    public static void printList(ArrayList list)
    {
      foreach (var item in list)
      {
        Console.WriteLine(item + " ");
      }
    }
  }
}