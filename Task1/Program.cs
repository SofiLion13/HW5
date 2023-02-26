// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray()
{
    int[] result = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int EvenNumbers = Math.Abs(int.Parse(Console.ReadLine()));
for (int i = 0; i <= EvenNumbers; i++)
if (i % 2 == 0)
{
    Console.Write($"{i} ");
}