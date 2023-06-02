// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void PrintArray(int[] array1, int[] array2)
{
    int count1 = array1.Length;
    for (int i = 0; i < count1; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    System.Console.WriteLine();
    
    int count2 = array2.Length;
        for (int i = 0; i < count2; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    System.Console.WriteLine();
}

int[] array1 = {1, 2, 5, 7, 19};
int[] array2 = {6, 1, 33};

PrintArray(array1, array2);