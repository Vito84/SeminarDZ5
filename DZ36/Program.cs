//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] initArray()
{
    int number = 5;
    int[] result = new int[number];
    Random rnd = new Random();

    for (int i = 0; i < number; i++)
    {
        result[i] = rnd.Next(-100, 100);
    }
    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void summaOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];

    }
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях ровна {sum}");

}
int[] arr = initArray();
printArray(arr);
summaOddNumbers(arr);