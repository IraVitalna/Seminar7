// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите строку: ");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец: ");
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = random.Next(10, 99);
Console.WriteLine("{0} ", array[i, j]);
}
Console.WriteLine();
}
    if (position1 < 0 | position1 > array.GetLength(0) - 1 | position2 < 0 | position2 > array.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[position1, position2]);
}
Console.ReadLine();
 
