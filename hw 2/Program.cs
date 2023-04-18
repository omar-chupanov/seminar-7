// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1


int ReadInt(string msg)
{
    System.Console.WriteLine($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int cntRows, int cntColunms)
{
    int[,] array = new int[cntRows, cntColunms];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int CheckingNumber(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count++;

            }
        }

    }
    return count;
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Ввелите количество колонн");
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);
int numb = ReadInt($"Введите число для поиска  ");
int cnt = CheckingNumber(array, numb);
if (cnt == 0)
{
    System.Console.Write("такого значения в массиве нет");
}
else
{

    System.Console.Write($"Количество, введенных значений равна > {CheckingNumber(array, numb)} ");
}    
