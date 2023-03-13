// Задача 3.
// Задайте массив вещевственных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5]

double[] CreateRndDblArr(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min), 1);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];  
    }
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];  
    }
    return max;
}

double[] array = CreateRndDblArr(10, 1, 30);

PrintArray(array);

double min = FindMin(array);
double max = FindMax(array);

double diff = max - min;
Console.WriteLine
(
$"\n\nРазница в минимальном -> {min} и максимальном -> {max} значенями в массивe равна {diff}"
);
