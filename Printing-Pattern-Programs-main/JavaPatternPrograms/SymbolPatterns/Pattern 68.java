class Pattern_190
{
    public static void main(String args[])
    {
        int n = 4;
        for (int i = n; i >= 0; i--)
        {
            for (int j = n; j >= 0; j--)
            {
                if (j > i)
                {
                    System.out.print("*");
                }
                else
                {
                    System.out.print((char)(i + 65));
                }
            }
            System.out.println("");
        }
    }
}