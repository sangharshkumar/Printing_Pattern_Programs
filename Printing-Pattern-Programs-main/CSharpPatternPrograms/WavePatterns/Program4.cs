﻿using System;

class Wave_4
{
 public static void Main(string[] args)
 {
  int waveHeight = 4; //change value to increase or decrease the height of wave


  int wL = 4; //wave length->change value to increase or decrease the length of wave


  int wH = waveHeight - 1; //for loop cond.

  int x = wH; //if cond for printing
  int cp; //print char


  for (int i = 0; i <= wH; i++)
  {
   cp = 'A'; // set print char.

   for (int j = 0; j <= wH * wL * 2; j++)
   {
    if (j % (wH * 2) == x || j % (wH * 2) == wH + i)
    {
     Console.Write((char)cp);
    }
    else
    {
     Console.Write(" ");
    }

    cp++; // increment print char

    /reset print char to 'A'/
    if (cp > 'Z')
    {
     cp = cp - 26;
    }

   }
   x--;
   Console.WriteLine();
  }
  Console.ReadKey(true);

 }
}
