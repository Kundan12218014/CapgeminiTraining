using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;
class Program
{
  // var m=0;//locallvel checked at Complietime 
  dynamic n = 10;//global checked at Runtime
  public static void Main()
  {
    AddClass addObject = new AddClass();
    int sumInt = addObject.AddInt(20, 30);
    Console.WriteLine($"Sum of Int is : {sumInt}");
    float sumFloat = addObject.AddFloat(20.2f, 30.1f);
    Console.WriteLine($"Sum of Float is : {sumFloat}");
    double sumDouble = addObject.AddDouble(20.2d, 30.1d);
    Console.WriteLine($"Sum of Double is : {sumDouble}");
    string sumString = addObject.AddString("Kundan ", "Kumar");
    Console.WriteLine($"Sum of string is : {sumString}");

    ////////////////////////////////////////////////////////////////////////////////////////

    AddGenericClass<int> addInt = new AddGenericClass<int>();
    int sumIntGeneric = addInt.AddAllType(30, 20);
    Console.WriteLine($"Sum int :{sumIntGeneric} ");

    AddGenericClass<float> addFloat = new AddGenericClass<float>();
    float sumFloatGeneric = addFloat.AddAllType(30.4f, 20.5f);
    Console.WriteLine($"Sum float :{sumFloatGeneric} ");

    AddGenericClass<string> addString = new AddGenericClass<string>();
    string sumStringGeneric = addString.AddAllType("Kundan ", "Kumar");
    Console.WriteLine($"concat string :{sumStringGeneric} ");

    AddGenericClass<int> intGenericParam = new AddGenericClass<int>(20, 20);

    /////////////////////////////////////////////////////////////////////////////////////

    List<string> list = new List<string>();
    list.Add("Kunda");
    list.Add("Rajesh");
    foreach (string l in list)
    {
      Console.WriteLine(l);
    }


    Employee emp1 = new Employee()
    {
      Id = 10,
      Name = "Gautam"
    };
    Employee emp2 = new Employee()
    {
      Id = 10,
      Name = "Gautam"
    };
    List<Employee> employees = new List<Employee>();
    employees.Add(emp1);
    employees.Add(emp2);
    foreach (Employee e in employees)
    {
      Console.WriteLine(e);
    }

    /////////////////////////////////////////////////////////////////////

    Dictionary<int, string> dict = new Dictionary<int, string>();
    dict.Add(100, "Kundan");
    dict.Add(99, "Kunal");
    foreach (KeyValuePair<int, string> item in dict)
    {
      Console.WriteLine($"key is : {item.Key},value is : {item.Value}");
    }

    ///////////////////////////////////////////////////////////////////////
    SortedList<string,string> pairs= new SortedList<string, string>();
    pairs.Add("100","Rajesh");
    pairs.Add("300","Rakesh");
    pairs.Add("200","RamNath");
    System.Console.WriteLine("Generic Sorted list");
    foreach(KeyValuePair<string,string>kvm in pairs)
    {
      System.Console.WriteLine($"key is {kvm.Key} value is : {kvm.Value}");
    }
/////////////////////////////////////////////////////////////
System.Console.WriteLine("Stack : ");
    Stack<char>stack=new Stack<char>();
    stack.Push('A');
    stack.Push('B');
    stack.Push('C');
    stack.Push('D');
    stack.Pop();
    foreach(var item in stack)
    {
      System.Console.WriteLine(item+" ");
    }
    System.Console.WriteLine("After Removal: ");
    foreach(var item in stack)
    {
      System.Console.WriteLine(item+" ");
    }

    /////////////////////////////////////////////////////////////
    
    System.Console.WriteLine("Generic Queue: ");
    Queue<char>queue=new Queue<char>();
    queue.Enqueue('A');
    queue.Enqueue('B');
    queue.Enqueue('C');
    queue.Enqueue('D');
System.Console.WriteLine("Enquing : ");
    foreach(var item in queue)
    {
      System.Console.Write($"{item} ");
    }
    queue.Dequeue();
    queue.Dequeue();

    System.Console.WriteLine("\nDequeing");
    foreach (var item in queue)
    {
      System.Console.Write($"{item} ");
    }


  }
  public static void BoxingUnboxing()
  {
    object o;
    int n = 10;
    o = n;//boxing

    string str = "1";
    int j = (int)o;//unboxing

    ArrayList list = new ArrayList();
    list.Add(10);//boxing
    list.Add(20);//boxing
    list.Add(false);//boxing
    list.Add(100.3f);//boxing

    int k = (int)list[0];//unboxing
    var v = list[1];//no unboxing here , v is of type object
    bool t = (bool)v;//unboxing
    var x = 0;
    // x = "Kundan";//showing error

    dynamic d = 10;
    d = "Kumar";//no error

  }
}