// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

//шаг 1. ввод данных
Console.WriteLine("Введите значение m (строки):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n (столбцы):");
int n = Convert.ToInt32(Console.ReadLine());

//шаг 2. задаем массив

double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

//шаг 3. заполняем массив

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 10));
        }
    }
}

//шаг 4. выводим массив
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}