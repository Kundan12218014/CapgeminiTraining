using System;
public class StringClass
{
  public static void Main()
  {
    //Question 44
    string s = Console.ReadLine();
    Console.WriteLine(s);
    //Question 45
    // string[] stringArray = new string[10]{};
    // for (int i = 0; i < stringArray.Length; i++)
    // {
    //   stringArray[i] = Console.ReadLine();
    // }
    //Question 46
    // a
    // int[,] matrix = new int[5, 5];
    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //   for (int j = 0; j < matrix.GetLength(1); j++)
    //   {
    //     if (!int.TryParse(Console.ReadLine(), out int value)) value = 0;
    //     matrix[i, j] = value;
    //   }
    // }
    //b
    int[,] mat1 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 7, 8, 9 }
    };

    int[,] mat2 =
    {
      { 10, 20, 30 },
      { 40, 50, 60 },
      { 70, 80, 90 }
    };

    int[,] result = new int[3, 3];

    for (int i = 0; i < result.GetLength(0); i++)
    {
      for (int j = 0; j < result.GetLength(1); j++)
      {
        result[i, j] = mat1[i, j] + mat2[i, j];
      }
    }

    for (int i = 0; i < result.GetLength(0); i++)
    {
      for (int j = 0; j < result.GetLength(1); j++)
      {
        Console.Write(result[i, j] + " ");
      }
      Console.WriteLine();
    }
    //Queston 47
    int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
    int largest = arr[0];
    int smallest = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] > largest)
      {
        largest = arr[i];
      }
      else if (arr[i] < smallest)
      {
        smallest = arr[i];
      }
    }
    Console.WriteLine($"Largest is : {largest} , Smallest is : {smallest}");

    //Question 48
    int[,] mat3 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 7, 8, 9 }
    };

    for (int i = 0; i < mat3.GetLength(0); i++)
    {
      for (int j = 0; j < mat3.GetLength(1); j++)
      {
        mat3[i, j] *= 2;
      }
    }

    for (int i = 0; i < mat3.GetLength(0); i++)
    {
      for (int j = 0; j < mat3.GetLength(1); j++)
      {
        Console.Write(mat3[i, j] + " ");
      }
      Console.WriteLine();
    }

    //question 49

    int[,] mat4 =
    {
      { 1, 2, 3 },
      { 4, 5, 6 },
      { 7, 8, 9 }
    };
    for (int i = 0; i < mat4.GetLength(0); i++)
    {
      for (int j = 0; j < i; j++)
      {
        int temp = mat4[i, j];
        mat4[i, j] = mat4[j, i];
        mat4[j, i] = temp;
      }
    }

    for (int i = 0; i < mat4.GetLength(0); i++)
    {
      for (int j = 0; j < mat4.GetLength(1); j++)
      {
        Console.Write(mat4[i, j] + " ");
      }
      Console.WriteLine();
    }
    // //question 50

    int[,] mat5 =
        {
      { 1, 0, 0 },
      { 0, 5, 0 },
      { 0, 0, 9 }
    };
    bool flag = true;
    for (int i = 0; i < mat5.GetLength(0); i++)
    {
      for (int j = 0; j < mat5.GetLength(1); j++)
      {
        if (i != j && mat5[i, j] != 0)
        {
          flag = false;
          break;
        }
      }
    }
    Console.WriteLine($"The matrix is Diagonal Matrix : {flag}");

    //question 52
    string myName = "Kundan Kumar";
    char[] myNameChar = myName.ToCharArray();
    Array.Reverse(myNameChar);
    string reverseMyName = new string(myNameChar);
    Console.WriteLine(reverseMyName);

    //question 53
    string MyNameSecond = "Kundan Kumar";
    char[] MyNameArray = MyNameSecond.ToCharArray();

    int left = 0, right = MyNameArray.Length - 1;
    while (left < right)
    {
      char temp = MyNameArray[left];
      MyNameArray[left] = MyNameArray[right];
      MyNameArray[right] = temp;
      left++;
      right--;
    }
    Console.WriteLine(new string(MyNameArray));

    //question 54
    string UpperName = "kundan kumar";
    char[] upperNameArray = UpperName.ToCharArray();

    for (int i = 0; i < upperNameArray.Length; i++)
    {
      if (upperNameArray[i] >= 'a' && upperNameArray[i] <= 'z')
      {
        upperNameArray[i] = (char)((int)(upperNameArray[i]) - 32);
      }
    }
    Console.WriteLine(new string(upperNameArray));

    //question 55
    string LoweName = "KUNDAN KUMAR";
    char[] LoweNameArray = LoweName.ToCharArray();

    for (int i = 0; i < LoweNameArray.Length; i++)
    {
      if (LoweNameArray[i] >= 'A' && LoweNameArray[i] <= 'Z')
      {
        LoweNameArray[i] = (char)((int)(LoweNameArray[i]) + 32);
      }
    }
    Console.WriteLine(new string(LoweNameArray));


    //question 56
    string str4 = "This is test";
    string str5 = "This is string";
    if (str4.CompareTo(str5) == 0)
    {
      Console.WriteLine("String is equal");
    }
    else
    {
      Console.WriteLine("String is not equal");
    }

    //question 57
    string str6 = "This is string";
    string str7 = "This is myString";
    int cmp = CompareManual(str6 ?? "", str7 ?? "");
    if (cmp == 0)
    {
      Console.WriteLine("String are equal");
    }
    else if (cmp < 0)
    {
      Console.WriteLine("first string is smaller");
    }
    else
    {
      Console.WriteLine("First string is greater");
    }

    //question 58
    string fName = "kundan ";
    string lName = "kumar";
    Console.WriteLine(string.Concat(fName, lName));

    //question 59
    string fName1 = "kundan ";
    string lName2 = "kumar";

    Console.WriteLine(ConcatManual(fName1, lName));

    //questoin 60
    string firstString = "Kundan Kumar";
    string searchString = "Kumar";
    Console.WriteLine($"search string {searchString} found in {firstString}: " + firstString.Contains(searchString));

  }
  public static int CompareManual(string a, string b)
  {
    int i = 0, j = 0;
    while (i < a.Length && j < b.Length)
    {
      if (a[i] != b[j])
      {
        return a[i] < b[j] ? -1 : 1;
      }
      i++; j++;
    }
    if (a.Length == b.Length) return 0;
    return a.Length < b.Length ? -1 : 1;

  }
  public static string ConcatManual(string a, string b)
  {
    a = a ?? "";
    b = b ?? "";
    char[] buffer = new char[a.Length + b.Length];
    int k = 0;
    for (int i = 0; i < a.Length; i++) buffer[k++] = a[i];
    for (int i = 0; i < b.Length; i++) buffer[k++] = b[i];
    return new string(buffer);
  }
}