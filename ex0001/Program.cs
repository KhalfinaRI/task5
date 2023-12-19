// Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.


void Show2dArray(int[,] array){
    for (int row = 0; row<array.GetLength(0); row++){
        for (int col = 0; col < array.GetLength(1); col++){
            Console.Write(array[row, col]);
        }
        Console.WriteLine();
    }
}

int[,] CreateArray(int row, int col, int min, int max){
    int[,] array2 = new int[row, col];
    for(int i = 0; i<row; i++)
        for (int j = 0; j< col; j++){
        array2[i, j] = new Random().Next(min, max+1);
    }
    
    return array2;
}

Console.Write("Enter rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = CreateArray(row, col, min, max);
Show2dArray(NewArray);

Console.Write("Enter row2: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter col2: ");
int col2 = Convert.ToInt32(Console.ReadLine());
if (row2<=NewArray.GetLength(0) && col2<=NewArray.GetLength(1) && row2>=0 && col2>=0)
{
    Console.WriteLine($"Index [{row2}, {col2}] in array = {NewArray[row2, col2]}");
} else {
    Console.WriteLine("Doesn't exist in array");
}


