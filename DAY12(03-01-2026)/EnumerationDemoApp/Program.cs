using System;
using System.Collections;
public class MyCollection: IEnumerable
{
  public int []data={1,2,3};
  public IEnumerator GetEnumerator()
  {
    return data.GetEnumerator();
  }
}
public class Program
{
  public static void Main()
  {
    MyCollection obj=new MyCollection();
    foreach(int i in obj)
    {
      Console.Write(i+" ");
    }
  }
}