// Задача 3: 
// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является
// ли этот день выходным

Console.Write("Введите день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if(dayNum == 6 || dayNum == 7) Console.WriteLine("Этот день выходной.");
else Console.WriteLine("Этот день не выходной.");