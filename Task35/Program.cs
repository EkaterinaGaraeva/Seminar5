/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArray(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation+1);
    }
    return arrayOfNumbers;
}

void PrintArray(int[] arrayOfNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (i != arrayOfNumbers.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int FindSum(int[] arrayOfNumbers, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] >= min && arrayOfNumbers[i] <= max)
        {
            count++;
        }
    }
    return count;
}

int[] arrayOfNumbers = GetArray(123, 199);
Console.Write("Исходный массив: ");
PrintArray(arrayOfNumbers);

int sum = FindSum(arrayOfNumbers, 10, 99);
Console.Write(sum);

