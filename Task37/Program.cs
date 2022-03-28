/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
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

int[] MultiplyOfArray (int[] arrayOfNumbers)
{
    int length = (int)Math.Ceiling(arrayOfNumbers.Length / 2.0);
    int[] multyArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        if (i == arrayOfNumbers.Length-1-i)
        {
            multyArray[i] = arrayOfNumbers[i];
        }
        else
        {
            multyArray[i] = arrayOfNumbers[i] * arrayOfNumbers[arrayOfNumbers.Length - 1 - i];
        }
    }
    return multyArray;
}

int[] arrayOfNumbers = GetArray(5, 9);
Console.Write("Исходный массив: ");
PrintArray(arrayOfNumbers);

int[] multy = MultiplyOfArray(arrayOfNumbers);
Console.Write("Измененный массив: ");
PrintArray(multy);