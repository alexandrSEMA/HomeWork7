//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Введите число строк");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов");
int m = int.Parse(Console.ReadLine());

double[,] mxn = new double [n, m];
FillArrayRandomDoubleNumbers(mxn);
PrinttDoubleArray(mxn);


void FillArrayRandomDoubleNumbers (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrinttDoubleArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
