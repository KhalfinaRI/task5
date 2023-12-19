// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


//using System.Globalization;

void Show2dArray(int[,] masiv)
{
    for (int row = 0; row < masiv.GetLength(0); row++)
    {
        for (int col = 0; col < masiv.GetLength(1); col++)
        {
            Console.Write(masiv[row, col] + " ");
        }
        Console.WriteLine();
    }
}


int[,] RandomNewArray(int row, int col, int min, int max)
{
    int[,] result = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    return result;
}


int ResultArray(int[,] array)
{
    int ArrayMinRow = 0;
    var min = int.MaxValue;   
    
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        if (sum < min){
            min = sum;
            ArrayMinRow = i;
        }
    }
    return ArrayMinRow;
}


Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = RandomNewArray(rows, columns, min, max);
Show2dArray(array);

Console.WriteLine($"Min value is row {ResultArray(array)} ");