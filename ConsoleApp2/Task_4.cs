using System;
namespace Task_4
{
public class Task_4
{
    public void main4()
    {
        // Введення розміру масиву
        Console.Write("Введіть розмір одновимірного масиву: ");
        int n = int.Parse(Console.ReadLine()!);

        // Створення та заповнення масиву
        int[,] array = new int[n, n];
        FillArray(array);

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Створення і заповнення нового масиву
        int[] array1 = new int[n];
        NumPositiveElInRows(array, array1);

        Console.Write("Новий масив із кількості додатних елементів в кожному ряду: \n");
        PrintArray1(array1);
    }

    static void FillArray(int[,] array)
    {
        Random random = new Random();
        int size = array.GetLength(0);
        int tempSize = 1;
        for (int i = 0; i < size; i++)
        {   
            for (int j = 0; j < tempSize; j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
            tempSize ++;
        }
    }

    static void PrintArray(int[,] array)
    {
        int size = array.GetLength(0);
        int tempSize = 1;
        for (int i = 0; i < size; i++)
        {   
            for (int j = 0; j < tempSize; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
            tempSize ++;
        }
    }

    static void NumPositiveElInRows(int[,] array, int[] array1)
    {
        int size = array.GetLength(0);
        int tempSize = 1;
        for (int i = 0; i < size; i++)
        {   
            int tempSum = 0;
            for (int j = 0; j < tempSize; j++)
            {
                if(array[i, j] > 0)
                {
                    tempSum ++;           
                }
                
            }

            array1[i] = tempSum;
            tempSize ++;
            tempSum = 0;          
        }
    }

    static void PrintArray1(int[] array1)
    {
        foreach (float element in array1)
        {
            Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
}