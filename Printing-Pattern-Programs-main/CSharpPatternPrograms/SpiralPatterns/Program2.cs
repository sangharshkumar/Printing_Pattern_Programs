using System;

class SpiralNumberRevPattern
{
    public static void Main(string[] args)
    {
        int n = 5; // change to change size
        int[,] a = new int[5, 5];
        int i,j;
        int ot;

        int x = 0;
        int y = 0;
        int z = 25;

        for (ot = 0; ot <= n / 2; ot++)
        {
            if (ot == n / 2)
            {
                z++;
            }
            for (j = y; j < n - y; j++)
            {
                a[x,j] = z;
                z--;
            }
            for (i = x + 1; i < n - x - 1; i++)
            {
                a[i,n-y-1] = z;
                z--;
            }
            for (j = n - y - 1; j >= y; j--)
            {
                a[n-x-1,j] = z;
                z--;
            }
            for (i = n - x - 2; i > x; i--)
            {
                a[i,y] = z;
                z--;
            }
            x++;
            y++;
        }

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write(" {0:D2}", a[i,j]);
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
