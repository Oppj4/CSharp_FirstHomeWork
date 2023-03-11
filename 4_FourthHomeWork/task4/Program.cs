// Задача 4.
// Напишите программу, которая задаёт
// массив из 8 элементов, заполненный
// псевдослучайныйми числами и выводит их 
// на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 5, 19, 6, 1, 33]


int[] array = new int[8];

void fill_array(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }    
}

void print_array(int[] arr) 
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length-1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }

}

fill_array(array);
print_array(array);