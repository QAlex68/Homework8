// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool SeekNumber3DArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void Print3dArray(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                Console.Write($"{massive[i, j, k]}({i},{j},{k})\t", -3);
            }
            Console.WriteLine();
        }
    }
}

int[,,] CreateAndFill3DArray(int sizeX, int sizeY, int sizeZ, int startValue, int finishValue)
{
    int[,,] matrix = new int[sizeX, sizeY, sizeZ];
    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                int num = new Random().Next(startValue, finishValue + 1);
                if (SeekNumber3DArray(matrix, num)) matrix[x, y, z] = num;
                else z--;
            }
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите количество строк массива: ");
int y = GetInput("Введите количество столбцов массива: ");
int z = GetInput("Введите глубину массива: ");
if (x * y * z <= 90)
{
    int start = GetInput("Введите начало диапазона значений элементов: ");
    int finish = GetInput("Введите конец диапазона значений элементов: ");
    int[,,] array3D = CreateAndFill3DArray(x, y, z, start, finish);
    Console.WriteLine($"Сгенерирован массив [{x}x{y}x{z}] в диапазоне от {start} до {finish} !");
    Print3dArray(array3D);
}
else Console.WriteLine($"Недопустимая размерность массива!!");