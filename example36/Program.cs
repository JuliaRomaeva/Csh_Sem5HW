﻿// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите длину массива: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine());
int[] array = FillArray(num, min, max);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max + 1);
    }
    return result;
}

int Count = 0;
for(int i = 0; i < array.Length; i++){
    int el = array[i];
    if(i % 2 == 1) 
    Count += el;    
}

Console.Write($"[{String.Join(", ", array)}] -> {Count}");

