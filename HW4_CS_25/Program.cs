/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);

int power(int numberA, int numberB)
{
    int temp = numberA;
    for (int i = 0; i < numberB - 1; i++)
    {
        temp = temp * numberA;

    }
    return temp;
}
int result = power(numberA, numberB);
Console.WriteLine($"{result}");
