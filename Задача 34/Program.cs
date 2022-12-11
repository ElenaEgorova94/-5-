// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] GetArray(int length)
{
    int[] array = new int[length];

    Random xxx = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = xxx.Next(100, 1000);
    }
    return array;
}


string PrintArray (int[] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        result += $"{arr[i]}  ";
    }
    return result;
}


int CheckEven(int[] ar)
{
    int res = 0;
    for(int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) 
        res++;
    }
    return res;
}


Console.WriteLine("Введите размер массива:  ");
int[] array = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine (PrintArray(array));

Console.WriteLine("Количество четных чисел в массиве:  " +  CheckEven (array));
