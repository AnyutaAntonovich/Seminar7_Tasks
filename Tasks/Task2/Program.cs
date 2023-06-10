// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Input the number of line");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of column");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
GetArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("No such element");
}
else
{
    Console.WriteLine($"Element value {n} of row and {m} of column is {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

