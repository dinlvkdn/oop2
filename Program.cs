using System;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 7;
            int k;
            int temp1 = 1, temp2 = 1, IndexMax = 0;
          
            int count = 0;

            int[,] matrix = new int[rows, cols];

            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-1, 36);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); 
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
            }


            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    k = j + 1;
                    while (k < 7)
                    {
                        if (matrix[i, j] == matrix[i, k])
                        {
                            temp1++;
                        }
                        k++;
                    }
                }
                if (temp1 > temp2)
                {
                    temp2 = temp1;
                    IndexMax = i;
                }

                temp1 = 1;
            }

            Console.WriteLine("Рядок, який має одинакові елементи" + IndexMax);
            Console.WriteLine("Кiлькiсть рядкiв з нулем: " + count);
        }
    }
}
