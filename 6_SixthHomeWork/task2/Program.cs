// Задача 2.
// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0.5; -0.5)

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void FindPoint(double x1, double y1, double x2, double y2)
{
    double x = (x2 - x1) / (y1 - y2);
    double y = k1 * x + b1;
    Console.WriteLine($"{Math.Round(x, 3)} : {Math.Round(y, 3)}");

}

FindPoint(b1, k1, b2, k2);