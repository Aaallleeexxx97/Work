using System;
          
public class Program
{
    public static void Main()
  {
  } 
     public static string[] input()
  {
    Console.WriteLine("Введите количество элементов массива");
    int leng = Convert.ToInt32(Console.ReadLine());
    string[] mass = new string[leng];
    for(int i = 0;i<leng;i++)
    {
      Console.WriteLine("введите "+(i+1)+" элемент массива");
      string temp = Convert.ToString(Console.ReadLine());
      mass[i] = temp;
    }
    return mass;
  }
  public static string[] Process(string[] mas)
  {
    string[] mass = mas;
    int j = 0;
    for(int i = 0;i<mass.Length;i++)
    {
      if(mass[i].Length <= 3)
      {
        j++;
      }
    }
    string[] nums = new string[j];
    //---------------------------------//
    int p = 0;
    for(int k = 0;k<j;k++)  
    {
      for(int i = p;i<mass.Length;i++)
      {
        p++;
        if(mass[i].Length <= 3)
        {
          nums[k] = mass[i];
          break;          
        }
      }
    }
    //---------------------------------//
    return nums;
  }
}



