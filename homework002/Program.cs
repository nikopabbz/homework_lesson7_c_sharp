// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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
void SearchElement(int[,] array)
{
    int lines = Prompt("Введите номер строки -> ");
    int columns = Prompt("Введите номер столбца -> ");
    if (lines > array.GetLength(0) || columns > array.GetLength(1)) 
    {
        System.Console.WriteLine("Такого элемента в массиве нет");
    }
    else System.Console.WriteLine($"{array[lines-1, columns-1]}");
}
var lines = Prompt("Введите количество строк -> ");
var columns = Prompt("Введите количество столбцов -> ");
int[,] array = Array(lines, columns);
SetOutput(array);
SearchElement(array);