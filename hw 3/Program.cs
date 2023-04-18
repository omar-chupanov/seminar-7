//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
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
double ArithmeticMean(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum = sum + array[j, 0];
    }
    return (sum / array.GetLength(0));
}



int rows = ReadInt("Введите количество строк ");
int columns = ReadInt("Ввелите количество колонн ");
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);
System.Console.WriteLine(ArithmeticMean(array));