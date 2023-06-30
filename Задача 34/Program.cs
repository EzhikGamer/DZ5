// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2|

// ===============НАЧАЛО===============
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
// ----------------------------------------------------------
int[] arr=FillArray(10,99,1000);
PrintArray(arr);
int evenNumber=0;
for(int i=0;i<arr.Length;i++)
{
    if(arr[i]%2==0)
    {
        evenNumber=evenNumber+1;
    }
    
}
if(evenNumber==0)
{
System.Console.WriteLine("Четные числа отсутствуют в массиве");
}
else System.Console.WriteLine($"Количество четных чисел в массиве: {evenNumber}");
// ===============КОНЕЦ===============