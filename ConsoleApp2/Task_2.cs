using System;
namespace Task_2
{
public class Task_2
{
    public void main2()
    {
        // Введення розміру масиву
        Console.Write("Введіть розмір одновимірного масиву: ");
        int size = int.Parse(Console.ReadLine()!);

        // Створення та заповнення масиву
        Console.Write("Введіть елементи одновимірного масиву: ");
        float[] array = new float[size];
        FillArray(array);

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Заміна max елементів на 0
        ReplaceMaxElement(array);

        // Виведення нового масиву
        Console.WriteLine("Масив після заміни максимальних елементів на 0:");
        PrintArray(array);
    }

    static void FillArray(float[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = float.Parse(Console.ReadLine()!);
        }
    }

    static void PrintArray(float[] array)
    {
        foreach (float element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void ReplaceMaxElement(float[] array)
    {
        float maxElement = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxElement){
                maxElement = array[i];
            }
        }

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == maxElement){
                array[i] = 0;
            }
        }

    }
    
}
}