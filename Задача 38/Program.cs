// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] GetArray(int length)
{
    double [] array = new double[length];

    Random xxx = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = xxx.NextDouble() * 100;
    }
    return array;
}


string PrintArray(double [] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        result += $"{arr[i]}  ";
    }
    return result;
}


double Find(double[] ar)
{
    double res = 0;
    double max = ar [0];
    double min = ar [0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] > max)
        {
            max = ar[i];
        }
        else if (ar[i] < min)
        {
            min = ar[i];
        }
    }
    res = max - min;
    return res;
}


Console.WriteLine("Введите размер массива:  ");
double [] array = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine(PrintArray(array));
Console.WriteLine("Разница между максимальным и минимальным элементами массива:  " + Find(array));