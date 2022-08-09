// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 10, 1);
    }
    return arr;
}

double DiffMaxMin(double[] array)
{
    double MaxNum = array[0];
    double MinNum = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxNum)
        {
            MaxNum = array[i];
        }
        if (array[i] < MinNum)
        {
            MinNum = array[i];
        }
    }
    double Diff = MaxNum - MinNum;
    return Diff;

}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndDouble(5, -10, 10);
PrintArray(array);

double result = Math.Round(DiffMaxMin(array), 1);

Console.WriteLine();

Console.WriteLine($"Разницу между максимальным и минимальным элементами массива = {result}");
