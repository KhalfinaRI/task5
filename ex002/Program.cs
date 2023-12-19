//  двумерный массив - меняет местами первую и последнюю строку массива


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


int[,] CreateArrayNew(int row, int col, int min, int max)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }
    return result;
}


int[,] FinalArray(int[,] NewArray){
    int[,] result = NewArray;
    int row2 = NewArray.GetLength(0)-1;
        for (int i = 0; i < result.GetLength(1); i++) {
            int index = NewArray[0, i];
            result[0, i] = NewArray[row2, i];
            result[row2, i] = index;
        }
    
    return result;
}

Console.Write("Enter rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Old array:");
int[,] NewArray = CreateArrayNew(row, cols, min, max);
Show2dArray(NewArray);
Console.WriteLine();
Console.WriteLine("New array: ");
Show2dArray(FinalArray(NewArray));