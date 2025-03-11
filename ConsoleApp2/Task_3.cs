using System;
using System.Diagnostics.SymbolStore;
namespace Task_3
{
public class Task_3
{
    public void main3()
    {
        // Введення розмірності двовимірного масиву
        Console.Write("Введіть n - розмір матриці: ");
        int n = int.Parse(Console.ReadLine()!);

        // Створення та заповнення масиву
        int[,] array = new int[n, n];
        FillArray(array);

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Обчислення суми елементів побічної діагоналі
        CoutSumOfHelpDiagonal(array);
    }

    static void FillArray(int[,] array)
    {
        Random random = new Random();
        int size = array.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void CoutSumOfHelpDiagonal(int[,] array)
    {
        int size = array.GetLength(0);
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if(i == size - j - 1){
                    sum = sum + array[i, j];
                }
            }
        }

        Console.WriteLine("Сума елементів побічної діагоналі: " + sum);
    }
}
}