Console.WriteLine("Напишите программу, которая принимает на вход три числа\r\nи выдаёт максимальное из этих чисел.\r\n");

Console.WriteLine("Введите три числа (разделитель - запятая):");

string[] numbers = Console.ReadLine().Split(new char[]{','});

if (numbers.Length != 3)
{
    Console.WriteLine("Количество введенных чисел не равно 3.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine($"Максиальное введенное число: {(numbers.Max())}");