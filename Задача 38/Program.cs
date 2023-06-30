// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// ===============НАЧАЛО===============
double[] FillArray(int size, double leftRange, double rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.NextDouble() * (rightRange - leftRange);
    }

    return tempArray;
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
// --------------------------------------------------------------

double[] arr = FillArray(10, 0, 100);
PrintArray(arr);
double min = arr[0];
double max = min;
for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i]) { max = arr[i]; }
    if (min > arr[i]) { min = arr[i]; }
}
System.Console.WriteLine($"Минимальный элемент массива равен, {Math.Round(min, 2)}, максимальный элемент массива равен, {Math.Round(max, 2)} ");
System.Console.WriteLine($"Разница максимального и минимального элемента массива равна {Math.Round(max - min, 2)}");
// ===============КОНЕЦ===============