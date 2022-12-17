// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.WriteLine("Введите кол-во строк массива:");
var rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива:");
var columns = int.Parse(Console.ReadLine());

var array = GetArrayMatrix(rows, columns, 0, 10);
PrintArray(array);
double [] middleArray = GetMiddle(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
int[,]result = new int[rows,columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    result[i, j] = new Random().Next(minValue, maxValue +1);
}
return result;
}

double[] GetMiddle(int[,] array)
{
double [] result = new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
         sum += array[j, i];
        }
        sum = Math.Round(sum / array.GetLength(0), 2);
        result[i] = Math.Round(sum / array.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое= {sum}");
    }
return result;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
    for (int j = 0; j < inArray.GetLength(1); j++)

    {
        Console.Write($"{inArray[i, j]}  ");
    }
    Console.WriteLine();
    }
}