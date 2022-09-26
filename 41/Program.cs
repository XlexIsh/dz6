// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int number);
        if (isNumber != true)
        {
            Console.WriteLine("Ошибка!");
            array[i] = -1;
            return array;
        }
        array[i] = number;
    }
    return array;
}

int[] array = FillArray(length);

int CountPosNumbers(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int count = CountPosNumbers(array);
Console.WriteLine($"Количество положительных чисел: {count}");