// Задача 2.
// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRndArr(int size, int min, int max) 
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
} 

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int OddCounter(int[] arr)
{
    int counter = 0;
    for(int i = 1; i < arr.Length; i += 2) counter += arr[i];

    return counter;
}

int[] array = CreateRndArr(12, -100, 100);

PrintArray(array);

Console.WriteLine($"\nКол-во нечётных чисел в массиве -> {OddCounter(array)}");