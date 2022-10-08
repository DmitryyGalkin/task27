/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Clear();

Console.WriteLine("введите число: ");

int num = int.Parse(Console.ReadLine()!);
int result = SumDigit(num);
Console.WriteLine(result);
SumDigit(num);
int SumDigit(int number)
{int sum = 0;
    for (int i = 1; num > 0; i++)
    {
        int div = num % 10;
        sum = sum + div;
        num = num / 10;
    }
    return sum;
}