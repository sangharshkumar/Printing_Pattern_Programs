﻿using System;

class Pattern_16
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
