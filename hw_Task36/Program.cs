// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



Console.WriteLine("Введите длину массива: "); 
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size]; 
Random rand = new Random(); 
for (int i = 0; i < size; i++) 
{ 
    arr[i] = rand.Next(0, 10); 
} 

 
Console.WriteLine(string.Join(", ", arr)); 
int sum = 0;
for (int i = 1; i < arr.Length; i+=2) 
{   
    sum = sum + arr[i];      
} 
 
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве: " + sum);