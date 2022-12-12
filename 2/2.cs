/* Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
 

int[,] numbers = new int[rows, columns];
Console.WriteLine("Массив: ");

for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1,10);
            Console.Write($"{numbers[i,j]} ");
        }
    
    Console.WriteLine();
    }
Console.WriteLine();

int index = 0;
int sumMax = int.MaxValue;

for(int i = 0; i < numbers.GetLength(0) ; i++)
    {
    
        int sum = 0;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
           sum += numbers[i, j];
           
        }
        if (sum < sumMax)
                {
                    sumMax = sum;
                    index = i;
                }
        
        Console.WriteLine("Сумма в {0} строке: {1}", i, sum);
    }
    Console.WriteLine();
    Console.WriteLine("Index строки с наименьшей суммой: "+index);

Console.WriteLine();