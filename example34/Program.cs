// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите длину массива трехзначных чисел: ");
int num = int.Parse(Console.ReadLine());

int[] array = FillArray(num, 100, 1000);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}

int CountEvenNumbers = 0;
for(int i = 0; i < array.Length; i++){
    int el = array[i];
    if(el % 2 == 0) 
    CountEvenNumbers = CountEvenNumbers + 1;    
}

Console.Write($"[{String.Join(", ", array)}] -> {CountEvenNumbers}");