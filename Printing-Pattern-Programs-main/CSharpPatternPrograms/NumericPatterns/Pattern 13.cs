﻿using System;

class Pattern_30
{
    public static void Main()
    {
     int n = 5; // size

     for (int i = n;i >= 1;i--)
     {
      for (int j = n - 1;j >= i;j--)
      {
      Console.Write(" ");
      }
      for (int k = 1;k <= i;k++)
      {
      Console.Write(i);
      }
      Console.WriteLine();
     }

        Console.ReadKey(true);
    }
}
