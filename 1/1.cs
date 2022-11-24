/*Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int sqr = 1;

for (int i = 1; i <= b; i++)
{
    sqr = sqr*a;
    
}
Console.WriteLine();
Console.WriteLine($"{a} в степени {b} равно: {sqr}");