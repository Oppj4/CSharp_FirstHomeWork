// Задача 2.
// Напишите цикл, который принимает 
// на вход два числа, (А и В) и возводит
// число А в натуральную степень В
// 3, 5 -> 243
// 2, 5 -> 16

Console.WriteLine("Введите число А ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int numB = Convert.ToInt32(Console.ReadLine());

int exponentiation(int A, int B)
{   
    
    int result = 1;
    for(int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine(exponentiation(numA, numB));