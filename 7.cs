using System;
class matrices
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value for row : ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for column : ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row, column];
        int[] r = new int[row];
        int[] c = new int[column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {
            r[i] = 0;
            for (int j = 0; j < column; j++)
            {
                r[i] = r[i] + arr[i, j];


            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)

            {
                
                c[j] = c[j] + arr[i, j];
            }
        }
        for (int i = 0; i < row; i++)
        {
            Console.Write(r[i] + " ");
        }
        for (int i = 0; i < column; i++)
        {
            Console.Write(c[i] + " ");
        }

    }
}