/* апишите программу, которая задаёт массив из N элементов
и выводит их на экран. Вывод сделать отдельным методом.*/

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int i = 0;

for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Mas();
}

void Mas()
{
    Console.Write(array[i] +"");
}