// Задача 38: Задайте массив натуральных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = GetArray(10, 1, 20);
Console.WriteLine(string.Join(", ", array));
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

int result = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {result}");