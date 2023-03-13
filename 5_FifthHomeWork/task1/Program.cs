// Задача 1.
// Задайте массив заполненый случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет
// кол-во чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRndArrElem(int size, int min, int max)
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
        if(i != arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int EvenCounter(int[] arr)
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] array = CreateRndArrElem(10, 100, 999);

PrintArray(array);
Console.WriteLine($"\nКол-во чётных чисел в массиве -> {EvenCounter(array)}");