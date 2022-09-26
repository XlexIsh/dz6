// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение k1:");
bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);

if (isNumberK1 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите значение b1:");
bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);

if (isNumberB1 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите значение k2:");
bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);

if (isNumberK2 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите значение b2:");
bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);

if (isNumberB2 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

if (k1 / k2 == 1)
{
    Console.WriteLine("Ошибка! Прямые с введёнными значениями не пересекаются!");
    return;
}

if ((k2 / k1) == (b2 / b1))
{
    Console.WriteLine("Ошибка! Прямые с введёнными значениями совпадают!");
    return;
}

double[] GetCoordinates(double k1, double k2, double b1, double b2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = (k2 * b1 - k1 * b2) / (k2 - k1);
    return array;
}

double[] array = GetCoordinates(k1, k2, b1, b2);

void PrintArray(double[] array)
{
    Console.WriteLine($"({array[0]}; {array[1]})");
}

PrintArray(array);