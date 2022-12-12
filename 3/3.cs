/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

Console.Write("Введите количество строк 1 матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2 матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] a = new int[rows, columns];
int[,] b = new int[rows1, columns1];

Console.WriteLine("Массив 1: ");
PrintArrayRandom(a);

Console.WriteLine("Массив 2: ");
PrintArrayRandom(b);

Console.WriteLine("Произведение двух матриц: ");

int[,] c = Multiplication(a, b);
PrintArray(c);

int[,] Multiplication(int[,] n, int[,] g)
        {
            
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[n.GetLength(0), g.GetLength(1)];
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(1); j++)
                {
                    for (int k = 0; k < g.GetLength(0); k++)
                    {
                        r[i,j] += n[i,k] * g[k,j];
                    }
                }
            }
            return r;
        }

void PrintArrayRandom(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }