// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
// ---------------------------------------------------------
int[] massive=FillArray(10,-100,100);
PrintArray(massive);
int sum=0;
for(int i=1;i<massive.Length;)
{
    {
        sum=sum+massive[i];
        i=i+2;
    }
    
System.Console.WriteLine(sum);
}
System.Console.WriteLine($"Сума чисел на нечетных позициях равна {sum}");
// ===============КОНЕЦ===============