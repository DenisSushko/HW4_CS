/*Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц,
если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.*/

int[] GenerateArray()
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = rnd.Next(2);
    }
    return arr;
}

int CountZeros(int[] arr)
{
    int count = 0;
    for (int i = 0; i < 8; i++)
    {
        if (arr[i] == 0)
        {
            count++;
        }
    }
return count;
}

void StockDigits (int count)
{
    if (count > 8 - count)
    {
        Console.WriteLine("true");
    }
    else 
    {
        Console.WriteLine("false");
    }
}
void PrintArray(int[] arr)
{
    string str = "[";

    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            str = str + arr[i] + "]";
        }
        else
            str = str + arr[i] + ", ";
    }
    Console.WriteLine(str);
}
int[] arr1 = GenerateArray();
PrintArray(arr1);
int count = CountZeros(arr1);
StockDigits (count);
