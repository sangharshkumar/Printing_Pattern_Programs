 class Pattern_129
 {
     public static void main(String args[])
     {
      int i;
      int j;
 
      int n = 9; //size (odd)
 
      int c1 = (n - 1) / 2; //cond
 
      int c2 = 3 * n / 2 - 1; //cond
 
      for (i = 0;i < n;i++)
      {
       for (j = 0;j < n;j++)
       {
         if (i + j == c1 || i - j == c1 || j - i == c1 || i + j == 
       c2 || i == c1 || j == c1)
         {
          System.out.print("* ");
         }
         else
         {
          System.out.print("  ");
         }
       }
       System.out.println("");
      }
     }
 }