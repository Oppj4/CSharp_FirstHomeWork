// Задача 2:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string numToString = Convert.ToString(num);

string result = "";

if (numToString.Length < 3) result = $"В числе {num} нет третьей цифры!";
else result = $"Третья цифра числа {num} -> {numToString[2]}";

Console.WriteLine(result);
