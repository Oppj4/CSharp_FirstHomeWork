// Задача 1.
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Вводите числа через пробел: ");
var UsrInput = Console.ReadLine()
               .Split()
               .Select(s => int.Parse(s))
               .ToArray(); 

void printArray(int[] arr)
{   
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == (arr.Length - 1)) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int EvenCounter(int[] arr)
{
    int counter = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0) counter++;
    }
    return counter;
}

printArray(UsrInput);

Console.WriteLine($" <- Введённые числа");
Console.WriteLine($"Кол-во чисел больше \"0\": {EvenCounter(UsrInput)}");