// Задача 5.
// Напишите программу, которая будет создвать
// копию заданного массива с помощью поэлементного
// копирования.


int[] array = {1, 2, 5, 7, 8, 3 };

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if (i == (arr.Length - 1)) Console.Write($"{arr[i]}"); 
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int[] CopyArr(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

PrintArray(array);

int[] newArr = CopyArr(array);

Console.WriteLine(" -> Изначальный\n");

PrintArray(newArr);
Console.WriteLine(" -> Копия\n");