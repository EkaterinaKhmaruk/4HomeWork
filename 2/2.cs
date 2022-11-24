/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

Console.Write("Введите число: ");
string? number = Console.ReadLine();
char[] massiv = number!.ToCharArray();
int sum = 0;

for (int i = 0; i < massiv.Length; i++)
{
    string element = Convert.ToString(massiv[i]);
    int element1 = Convert.ToInt32(element);
    sum = sum + element1;
}
Console.WriteLine("Сумма цифр этого числа: "+ sum);


