// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

Console.Clear();
int num = 123;

int[] array = FillArray(num, 0, 1001);

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}

int Count = 0;
for(int i = 0; i < array.Length; i++){
    int el = array[i];
    if(el > 9 && el < 100) 
    Count = Count + 1;    
}

Console.Write($"[{String.Join(", ", array)}] -> {Count}");