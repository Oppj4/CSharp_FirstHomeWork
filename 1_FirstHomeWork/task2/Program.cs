// Задача 2:
// Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из
// этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

int max = 0;
for(int i=1; i < 4; i++)
{
    Console.Write($"Введите {i}-ое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > max)
    {
        max = num;
    }
}
Console.WriteLine($"Максимальное число {max}");