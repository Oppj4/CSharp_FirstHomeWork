// Задача 1: 
// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли
// оно палидромом

Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());

string IsPalindrome(long n)
{
    string numToString = Convert.ToString(n);
    string temp = "";

    for(int i = numToString.Length-1; i >= 0; i--) temp += numToString[i];

    long convertTemp = Convert.ToInt64(temp);

    if(convertTemp == n) return $"Число {n} является палидромом";
    return $"Число {n} не является палидромом";
}

Console.WriteLine(IsPalindrome(num));