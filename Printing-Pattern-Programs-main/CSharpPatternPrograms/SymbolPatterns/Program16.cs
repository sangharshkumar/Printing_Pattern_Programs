﻿using System;

class Pattern_96
 {
  public static void Main()
   {
    int n = 5; // size
    int px = n;
    int py = n;

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j < n * 2; j++)
       {
        if (j > px && j < py)
         {
          Console.Write(" ");
         }
        else
         {
          Console.Write("*");
         }
       }
     px--;
     py++;

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
