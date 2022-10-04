// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] GetArray (int size, 100, 999);


Console.WriteLine("Введите длину массива: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
 
int[] arr = new int[size]; 
Random rand = new Random(); 
for (int i = 0; i < size; i++) 
{ 
    arr[i] = rand.Next(100, 1000); 
} 
 
 
int sum = 0; 
Console.WriteLine(string.Join(", ", arr)); 
for (int i = 0; i < arr.Length; i++) 
{ 
    int array = arr[i] % 2; 
 
    if (array == 0) 
    { 
        sum = sum + 1;   
    }   
} 
 
Console.WriteLine($"Количество четных чисел в массиве: " + sum);
