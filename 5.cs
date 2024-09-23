using System;
class matrix
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Matrix 1");
        Console.WriteLine("Enter the value for row : ");
        int row = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        Console.WriteLine("Enter the value for column : ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Matrix 2");
        Console.WriteLine("Enter the value for row : ");
        int row1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for column : ");
        int column1 = Convert.ToInt32(Console.ReadLine());
        int[,] arr1 = new int[row, column];
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column1; j++)
            {
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column1; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < row1; k++)
                {
                    for (int l = 0; l < column1; l++)
                    {
                        if (arr[i, j] == arr1[k, l])
                        {
                            found = true;
                        }
                        else
                        {
                            found = false;
                        }

                    }
                }

            }
        }
        if (found)
        {
            Console.WriteLine("The two matrices are equal.");
        }
        else
        {
            Console.WriteLine("The two matrices are not equal.");
        }
    }
}
