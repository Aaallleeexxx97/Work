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
}


