// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = CreateArray(rows, columns);
PrintArray(array);


Console.Write("Введите искомый столбец: ");
int findColumn = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите искомую строку: ");
int findRow = int.Parse(Console.ReadLine() ?? "");

GetElement(array, findRow, findColumn);


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

static void GetElement(int[,] inArray, int pos1, int pos2)
{
    if (pos1 > inArray.GetLength(0) || pos2 > inArray.GetLength(1))
    {
        Console.WriteLine($"{pos1}, {pos2} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(inArray[pos1-1, pos2-1]);
    }
}
