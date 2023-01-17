//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] initArray()
{
    int number = 5;
    int[] result = new int[number];
    Random rnd = new Random();

    for (int i = 0; i < number; i++)
    {
        result[i] = rnd.Next(0, 100);
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

void getDiff(int[] array)
{
    int maxMeaning = array[0];
    int minMeaning = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxMeaning)
            maxMeaning = array[i];
        if (array[i] < minMeaning)
            minMeaning = array[i];
            
    }
     Console.WriteLine($"Разница между максимальным {maxMeaning} и минимальным {minMeaning} элементом массива равна {maxMeaning - minMeaning}");
}
int[] arr = initArray();
printArray(arr);
getDiff(arr);