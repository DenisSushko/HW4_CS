/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/



int[] SeparateDigits(int num, int count)
{
    int[] arr = new int[count];
    int temp = 0;
    for (int i = 0; i < count; i++)
    {
        if (i == 0)
        {
            arr[i] = (num / Convert.ToInt32(Math.Pow(10, count - i - 1)));
        }
        else
        {
            temp = 0;
            for (int j = 0; j < i; j++)
            {
                temp += arr[j] * Convert.ToInt32(Math.Pow(10, i - j));
            }
            arr[i] = (num / Convert.ToInt32(Math.Pow(10, count - i - 1))) % temp;
        }

    }
    return arr;
}
int countDigits(int numArg)
    {
        int count = 1;
        int temp = numArg;
        while (temp > 10)
        {
            temp /= 10;
            count++;
        }
        return count;
    }
int SumArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result = result + arr[i];
    }
    return result;
}
Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine()!);

//int[] array1 = SeparateDigits(numberA);
//int result1 = SumArray(array1);
int count = countDigits(numberA);
int result = SumArray(SeparateDigits(numberA, count));
Console.WriteLine($"Сумма цифр в введенном числе: {result}");