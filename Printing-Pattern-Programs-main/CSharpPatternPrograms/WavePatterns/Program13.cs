﻿using System;

 class Wave_13
 {
  public static void Main(string[] args)
  {
   int wH = 4; //wave height-> change value to increase or decrease the height of wave


   int wL = 4; //wave length->change value to increase or decrease the length of wave


   int x = wH - 1; //if cond for printing

   int cp; //print char

   for (int i = 0; i <= wH; i++)
   {
    cp = 'a'; // set print char.

   for (int j = 0; j < wH * wL * 2; j++)
   {

    if (j % (wH * 2) == x || j % (wH * 2) == wH + i)
    {
     Console.Write((char)cp);
    }
    else
    {
     Console.Write(" ");
    }

    cp++; // increment print char

    /reset print char to 'a'/
    if (cp > 'z')
    {
      cp = cp - 26;
    }

    }
    x--;
    Console.WriteLine();
   }
   Console.ReadKey(true);
  }
 }
