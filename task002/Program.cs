// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void MinSumRow(int[,] massive)
{
    int numberRow = 1;
    int result = 0;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        result = result + massive[0, j];
    }
    for (int i = 1; i < massive.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            sum = sum + massive[i, j];
        }
        if (result > sum)
        {
            result = sum;
            numberRow++;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой это строка № {numberRow}!");
}


void Print2dArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] Create2dArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int start = GetInput("Введите начало диапазона значений элементов: ");
int finish = GetInput("Введите конец диапазона значений элементов: ");
int[,] array2D = Create2dArray(m, n, start, finish);
Console.WriteLine($"Сгенерирован массив [{m}x{n}] в диапазоне от {start} до {finish} !");
Print2dArray(array2D);
MinSumRow(array2D);
