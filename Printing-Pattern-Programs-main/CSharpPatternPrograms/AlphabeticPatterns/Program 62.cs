using System;

class Pattern_164
{
    public static void Main()
     {
       int n = 5; //size
       int i;
       int j;
       int s;

     for (i = 1;i <= n;i++)
    {
      for (s = n - 1;s >= i;s--)
      {
        Console.Write(" ");
      }
      for (j = 1;j <= i;j++)
      {
      if (i % 2 != 0)
      {
       Console.Write((char)(i + 64) + " ");
      }
      else
      {
       Console.Write(i + " ");
      }
      }
     Console.WriteLine();
    }
          Console.ReadKey(true);
   }
}
