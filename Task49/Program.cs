//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.WriteLine("Введите номер строки");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите чномер столбца");
int m = int.Parse(Console.ReadLine());
int[,] numbers = new int [5,5];
FillArrayRandomeNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента = {numbers[n-1,m-1]}");
}

PrinttArray(numbers);


void FillArrayRandomeNumbers (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrinttArray (int[,] array)
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