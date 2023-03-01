// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Введите массив через пробел: ");
string arr = Console.ReadLine();
int[] array = GetArrayFromString(arr);

int[] GetArrayFromString(string stringArray){
string[] nums = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];
 for(int i = 0; i < nums.Length; i++ ){
    res[i] = int.Parse(nums[i]);
 }
 return res;
}
int[] newarray = NewArray(array); // задали новый массив для произведений

int[] NewArray(int[] array) // функция поиска произведений пар чисел
{
    int newsize = (array.Length + 1)/ 2; 
    int[] result = new int[newsize]; // задали массив с новой длиной 
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i]; // формула произведения пар зеркальных чисел
    }
    if (array.Length % 2 == 1) 
    result[newsize-1] = array[array.Length / 2];
    return result;
}

Console.Write($"[{String.Join(", ", array)}] -> {String.Join(", ", newarray)}");