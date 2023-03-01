// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int GetDiff(int[] array) // функция поиска разницы между максимальным и минимальным элементами
{
    int imin = array[0]; // задаем минимальным первый элемент
    int imax = array[0];// задаем максимальный первый элемент
    foreach (int el in array) // перебираем элементы 
    {
        if (imin > el) imin = el;
        if (imax < el) imax = el;
    }
    return imax - imin; // возвращаем разницу
}
Console.Write($"[{String.Join(", ", array)}] -> {GetDiff(array)}");