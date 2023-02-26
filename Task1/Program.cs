// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
int GetCount(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            count++;
    }
    return count;
}
int[] arr = InitArray(10);
Console.WriteLine(string.Join(',', arr));
int count = GetCount(arr);

Console.WriteLine($"Кол-во четных элементов = {count}");