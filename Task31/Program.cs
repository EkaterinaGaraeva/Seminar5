/*
Задача 31: Задайте массив из 12 элементов, 
заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] GetArrayOfNumber(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation+1);
    }
    return arrayOfNumbers;
}

int GetPositiveSumElementOfArray(int[] arrayOfNumbers)
{
    int positiveSum = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] > 0)
        {
            positiveSum += arrayOfNumbers[i];
        }
    }
    return positiveSum;
}

int GetNegativeSumElementOfArray(int[] arrayOfNumbers)
{
    int negativeSum = 0;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] < 0)
        {
            negativeSum += arrayOfNumbers[i];
        }
    }
    return negativeSum;
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

int[] arrayOfNumbers = GetArrayOfNumber(12,9);
int positiveSum = GetPositiveSumElementOfArray(arrayOfNumbers);
int negativeSum = GetNegativeSumElementOfArray(arrayOfNumbers);
Console.WriteLine("В массиве: ");
PrintArray(arrayOfNumbers);

Console.WriteLine($"Сумма положительных {positiveSum}, сумма отрицательных {negativeSum}");

