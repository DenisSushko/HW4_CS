/* Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное 
число и выдаёт количество цифр в числе.
452 -> 3
82 -> 2
9,012 ->4*/

int countDigits(double numArg)
{
    int count = 1;
    double temp1 = numArg;
    while (temp1 > 10)
    {
        temp1 /= 10;
        count++;
    }
    double temp2 = numArg;
    while (temp2 != (long)temp2)
    {
        temp2 *= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Enter your number:");
double num = double.Parse(Console.ReadLine()!);
int count = countDigits(num);
Console.WriteLine(count);