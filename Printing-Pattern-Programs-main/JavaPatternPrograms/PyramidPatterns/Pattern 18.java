class Pattern_51
{
    public static void main(String args[])
    {
        int p_height=4;
        int width=p_height*2-1;
        int p_space=p_height-1;

        for (int i = p_height - 1; i >= 0; i--)
        {
            for (int j = p_space; j >i; j--)
            {
                System.out.print(" ");
            }
            for (int k = 1; k <= width; k++)
            {
                System.out.print((char)(i + 65));
            }
            width -= 2;
            System.out.println("");
        }

    }
}