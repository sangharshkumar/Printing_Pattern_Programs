﻿using System;

class Pattern_214
{
    public static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
