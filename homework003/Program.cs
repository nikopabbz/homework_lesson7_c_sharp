// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Prompt(string msg)
{
    Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}
int[,] Array(int lines, int columns)
{
    var array = new int[lines, columns];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void SetOutput(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void Average(int[,] array)
{
    double sum = 0;
    double average = 0;
    int index = 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = sum / array.GetLength(0);
        System.Console.WriteLine($"Среднее арифмитическое {index}-го столбца = {average}");
        average = 0;
        sum = 0;
        index++;
    }
}

var lines = Prompt("Введите количество строк -> ");
var columns = Prompt("Введите количество столбцов -> ");
var array = Array(lines, columns);
SetOutput(array);
Average(array);