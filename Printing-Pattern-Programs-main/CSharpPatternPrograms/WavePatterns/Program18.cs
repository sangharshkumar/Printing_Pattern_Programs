﻿using System;

   class Wave_18
 {
    public static void Main(string[] args)
    {

    int wave_height = 5; //change  value to increase or decrease the height of wave
    int wave_length = 4; //change  value to increase or decrease the length of wave

    int i;
    int j;
    int k;
    int @is = 1; //inner space
    int os = 2; //outer space

    int inc = 1;
    int jump = (wave_height * 3) - (wave_height + 1);

    int ch = 'A' + wave_height - 1;




    for (i = 1;i <= wave_height;i++)
    {
      for (j = 1;j <= wave_length;j++)
      {
       for (k = 1;k <= os;k++)
       {
        Console.Write(" ");
       }

        Console.Write((char)ch);

       for (k = 1;k <= @is;k++)
       {
        Console.Write(" ");
       }
         ch += inc;

         if (ch > 'Z')
         {
         ch = ch - 26;
         }

        Console.Write((char)ch);

       for (k = 1;k <= os;k++)
       {
        Console.Write(" ");
       }

     Console.Write(" ");
    ch += jump;
    if (ch > 'Z')
    {
    ch = ch - 26;
    }
      }

    os = ((i + 1) != wave_height)?1:0;
       /* set value of os to 1 if i+1 is not equal to wave height or 0 otherwise*/


       @is = (i + 1 != wave_height)?3:5;
       /* set value of is to 3 if i+1 is not equal to wave height or 5 otherwise*/

       ch = 'A' + wave_height - i - 1;
       inc = inc + 2;
       jump -= 2;

       Console.WriteLine();
    }

        Console.ReadKey(true);
    }
 }
