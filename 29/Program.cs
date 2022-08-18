// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int n = 8;

int[] CreateArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
       Random rnd = new Random();
       array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(CreateArray(n));

