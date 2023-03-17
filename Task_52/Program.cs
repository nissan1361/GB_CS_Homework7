// Задача 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = CreateArray(rows, columns);
PrintArray(array);

GetColumnMiddle(array);

static int[,] CreateArray(int m,int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10, 100);
        }
    }

    return result;
}


static void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

static void GetColumnMiddle(int[,] inArray)
{
    double middle = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        middle = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            middle += inArray[j, i];
        }
        middle /= inArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца = {middle}");
    }
}
