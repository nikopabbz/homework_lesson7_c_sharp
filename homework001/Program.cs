// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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
double[,] Array(int lines, int columns)
{
    var array = new double[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}
void SetOutput(double[,] array)
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

var lines = Prompt("Введите количество строк -> ");
var columns = Prompt("Введите количество столбцов -> ");
double[,] array = Array(lines, columns);
SetOutput(array);
