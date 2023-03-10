
Console.WriteLine("Введите координату A:");
int aX = Convert.ToInt32(Console.ReadLine());
int aY = Convert.ToInt32(Console.ReadLine());
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B:");

int bX = Convert.ToInt32(Console.ReadLine());
int bY = Convert.ToInt32(Console.ReadLine());
int bZ = Convert.ToInt32(Console.ReadLine());


double FindDist(int aX, int aY, int aZ, int bX, int bY, int bZ)
{
    double abX = Math.Pow(bX - aX, 2);
    double abY = Math.Pow(bY - aY, 2);
    double abZ = Math.Pow(bZ - aZ, 2);
    double d = Math.Sqrt(abX + abY + abZ);
    return d;
}

Console.WriteLine(FindDist(aX, aY, aZ, bX, bY, bZ));