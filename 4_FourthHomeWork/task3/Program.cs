// Задача 3.
// Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum_num(int n)
{   
    int result = 0;

    if(n < 0) n *= -1;

    while(n != 0)
    {   
        result += (n % 10);
        n /= 10;
    }
    return result;
}

Console.WriteLine(sum_num(num));