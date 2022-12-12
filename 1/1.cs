/*Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.*/

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] numbers = new int[n, n];
int[,] numbersSort = new int[n, n]; 
int[] temp = new int[n];
            
Console.WriteLine("Массив: ");            
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
            numbersSort[i, j] = numbers[i, j];
            
            Console.Write(" "+ numbers[i, j]);
        }
        Console.WriteLine();
        }
        

Console.WriteLine(); 
Console.WriteLine("Сортировка по строкам: ");

for (int i = 0; i < n; i++)

    {
        for (int j = 0; j < n; j++)
        {
            temp[j] = numbersSort[i, j];
            Array.Sort(temp);
            Array.Reverse(temp);
        }
            for (int k = 0; k < n; k++)
                {
                    numbersSort[i, k] = temp[k];
                    Console.Write(" "+ numbersSort[i, k]);
                }
        Console.WriteLine();
    }
Console.WriteLine(); 
        
 



