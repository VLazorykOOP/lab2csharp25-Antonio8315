using System;
using Task_1;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Task_1.Task_1 myTask_1 = new Task_1.Task_1();
        // string myTask_1a = myTask_1.speech();
        // Перший спосіб - Одновимірний масив
        // """
        // Console.WriteLine("Спосіб 1: Одновимірний масив");
        // WorkWithOneDimensionalArray();

        // Console.WriteLine("\nСпосіб 2: Двовимірний масив");
        // WorkWithTwoDimensionalArray();

        

        // Console.ReadKey();
        // """

        Task_1.Task_1 myTask_1 = new Task_1.Task_1();
        myTask_1.main1();

        // Task_2.Task_2 myTask_2 = new Task_2.Task_2();
        // myTask_2.main2();

        Task_3.Task_3 myTask_3 = new Task_3.Task_3();
        myTask_3.main3();
    }

    static void WorkWithOneDimensionalArray()
    {
        // Введення розміру масиву
        Console.Write("Введіть розмір одновимірного масиву: ");
        int size = int.Parse(Console.ReadLine()!);

        // Створення та заповнення масиву
        int[] array = new int[size];
        FillArray(array);

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Введення інтервалу
        Console.Write("Введіть нижню межу інтервалу: ");
        int lowerBound = int.Parse(Console.ReadLine()!);
        Console.Write("Введіть верхню межу інтервалу: ");
        int upperBound = int.Parse(Console.ReadLine()!);

        // Заміна елементів, що потрапляють в інтервал
        ReplaceElementsInRange(array, lowerBound, upperBound);

        // Виведення зміненого масиву
        Console.WriteLine("Масив після заміни елементів в інтервалі [{0}, {1}] на нуль:", lowerBound, upperBound);
        PrintArray(array);
    }

    static void WorkWithTwoDimensionalArray()
    {
        // Введення розмірності двовимірного масиву
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine()!);

        // Створення та заповнення двовимірного масиву
        int[,] array2D = new int[rows, cols];
        FillArray(array2D);

        // Виведення початкового масиву
        Console.WriteLine("Початковий двовимірний масив:");
        PrintArray(array2D);

        // Введення інтервалу
        Console.Write("Введіть нижню межу інтервалу: ");
        int lowerBound = int.Parse(Console.ReadLine()!);
        Console.Write("Введіть верхню межу інтервалу: ");
        int upperBound = int.Parse(Console.ReadLine()!);

        // Заміна елементів, що потрапляють в інтервал
        ReplaceElementsInRange(array2D, lowerBound, upperBound);

        // Виведення зміненого масиву
        Console.WriteLine("Масив після заміни елементів в інтервалі [{0}, {1}] на нуль:", lowerBound, upperBound);
        PrintArray(array2D);
    }

    // Методи для одновимірного масиву
    static void FillArray(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 101);
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void ReplaceElementsInRange(int[] array, int lowerBound, int upperBound)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= lowerBound && array[i] <= upperBound)
            {
                array[i] = 0;
            }
        }
    }

    // Методи для двовимірного масиву
    static void FillArray(int[,] array)
    {
        Random random = new Random();
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
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

    static void ReplaceElementsInRange(int[,] array, int lowerBound, int upperBound)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] >= lowerBound && array[i, j] <= upperBound)
                {
                    array[i, j] = 0;
                }
            }
        }
    }
}