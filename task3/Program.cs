// Задача 3:
// Напишите программу, которая на вход
// принимает число и выдаёт, является ли оно
// чётным.
string result = "";

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) result = "Чётное";
else result = "Нечётное";

Console.WriteLine($"Число {num} - {result}");

