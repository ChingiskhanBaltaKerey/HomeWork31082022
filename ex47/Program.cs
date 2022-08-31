//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int [,] CteateArray (int rows, int cols)
{
    return new int [rows, cols];
}
void Fill(int[,] array)
{
    int rows = array.GetLength(0);
    int cols =  array.GetLength (1);
    for (int row = 0; row < rows; row++)
{ 
    for (int col = 0; col < cols; col++)
    {
        array [row, col] = new Random ().Next(-10,10);
    }
    }

}
void Print (int [,]array)
{
    int rows = array.GetLength (0);
    int cols = array.GetLength (1);
    for (int row = 0; row < rows; row++)
{ 
    for (int col = 0; col < cols; col++)
    {
       Console.Write($"{array [row,col],3}");
    }
    Console.WriteLine();
    }
}
int m = 3;
int n = 5;

int [,] matrix = CteateArray (m,n);
Fill (matrix);
Print (matrix); 

