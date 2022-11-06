/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arrayInput()
{
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите массив");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    string str = "[";

    Console.WriteLine("Полученный массив: ");
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
PrintArray(arrayInput());

