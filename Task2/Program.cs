// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0,100);
    }
    return result;
}

void PrintArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]} ");
    }
    Console.WriteLine();
}

int GetOddSum(int[] number)
{
    int sum = 0;
    for (int i = 1; i < number.Length; i+=2)
    {
        sum = sum + number[i];
    }
    return sum;
}

int[] arr = InitArray();
PrintArray(arr);
int sum = GetOddSum(arr);

Console.WriteLine($"Сумма нечетных позиций = {sum}");