//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.




int [,] array = new int [3,4];
int srAr = 0;

void Fill (int[,] array)
{
    int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

    for (int i = 0; i < 3; i++)
    {
        int srAr = 0;
        for (int j = 0; j < 4; j++)
        {
            srAr += array[i, j];
            
        }
        Console.Write($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 3}");
        }
}
void Print (int [,]array)
{
    int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

    for (int i = 0; i < 3; i++)
    {
        int srAr = 0;
        for (int j = 0; j < 4; j++)
        {
            srAr += array[i, j];
            
        }
        Console.Write($"Cреднее арифметическое элементов столбца {j + 1} = {(float)srAr / 3}");
        }
}
Fill (srAR);
Print (srAr);
