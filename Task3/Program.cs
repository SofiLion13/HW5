// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] number = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    number[i] = rnd.Next(0, 100);
}

int min = 100;
int max = -1;
for (int i = 0; i < number.Length; i++)
{
    if(number[i] > max)
    {
        max = number[i];
    }
    if(number[i] < min)
    {
        min = number[i];
    }
}

Console.WriteLine(string.Join(',', number));
Console.WriteLine($"Максимальное число {max}, минимальное число {min}");
Console.WriteLine($"Разница = {max-min}");