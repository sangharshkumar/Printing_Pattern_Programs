﻿using System;

class Pattern_111
{
    public static void Main(string[] args)
    {
        int n = 5; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j || i + j == n + 1)
                {
                    Console.Write("x "); //ANY SYMBOL
                }
                else
                {
                    Console.Write("o "); //ANY SYMBOL
                }
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
