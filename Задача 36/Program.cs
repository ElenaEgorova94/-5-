// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int length)
{
    int[] array = new int[length];

    Random xxx = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = xxx.Next(-100, 100);
    }
    return array;
}


string PrintArray(int[] arr)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        result += $"{arr[i]}  ";
    }
    return result;
}

int Sum (int[] ar)
{
    int res = 0;
    for (int i = 1; i < ar.Length; i += 2)
    {
         res += ar[i];
    }
    return res;
}



Console.WriteLine("Введите размер массива:  ");
int[] array = GetArray(int.Parse(Console.ReadLine()));
Console.WriteLine(PrintArray(array));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + Sum (array));