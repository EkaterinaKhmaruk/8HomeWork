//Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] array = new int[n, n];
int sum = 1;

Console.WriteLine();
Console.WriteLine("Спиральный массив: ");
Console.WriteLine();              

for (int j = 0; j < n; j++) 
{
    array[0,j] = sum;
    sum++;
}
for (int i = 1; i < n; i++) {
    array[i,n - 1] = sum;
    sum++;
}
for (int j = n - 2; j >= 0; j--) {
    array[n - 1,j] = sum;
    sum++;
}
for (int i = n - 2; i > 0; i--) {
    array[i,0] = sum;
    sum++;
}
 
int x = 1;
int y = 1;
 
while (sum < n * n) {
          
    while (array[x,y + 1] == 0)
    {      
        array[x,y] =  sum;
        sum++;
        y++;
    }
 
    while (array[x + 1,y] == 0)
    {
        array[x,y] = sum;
        sum++;
        x++;
    }
 
    while (array[x,y - 1] == 0)
    {
        array[x,y] = sum;
        sum++;
        y--;
    }

    while (array[x - 1,y] == 0)
    {
        array[x,y] = sum;
        sum++;
        x--;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array[i,j] == 0) array[i,j] = sum;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++) 
    {
        if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");            
    }
        Console.WriteLine(" ");
}
Console.WriteLine();
