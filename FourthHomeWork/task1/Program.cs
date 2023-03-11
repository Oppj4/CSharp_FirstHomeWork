// Задача 1.
// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел
// от 1 до (A)

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

double sum (long n)
{
    if(n == 1) return 1;
    else return n + sum(n-1);
}

Console.WriteLine(sum(num));
