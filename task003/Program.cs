// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if (cols1 != rows2) Console.WriteLine("Несовместимые размеры массивов!");
    else
    {
        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("Результат перемножения массивов №1 и №2:");
        Print2dArray(resultMatrix);
    }
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

int m = GetInput("Введите количество строк массива 1: ");
int n = GetInput("Введите количество столбцов массива 1: ");
int start = GetInput("Введите начало диапазона значений элементов: ");
int finish = GetInput("Введите конец диапазона значений элементов: ");
int[,] array2D1 = Create2dArray(m, n, start, finish);
int m2 = GetInput("Введите количество строк массива 2: ");
int n2 = GetInput("Введите количество столбцов массива 2: ");
int start2 = GetInput("Введите начало диапазона значений элементов: ");
int finish2 = GetInput("Введите конец диапазона значений элементов: ");
int[,] array2D2 = Create2dArray(m2, n2, start2, finish2);
Console.WriteLine($"Сгенерирован массив №1 [{m}x{n}] в диапазоне от {start} до {finish} !");
Print2dArray(array2D1);
Console.WriteLine($"Сгенерирован массив №2 [{m}x{n}] в диапазоне от {start} до {finish} !");
Print2dArray(array2D2);
MultiplyMatrices(array2D1, array2D2);