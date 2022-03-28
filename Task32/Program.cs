/*
Задача 32: Напишите программу замена элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] ModifiedArray(int[] arrayOfNumbers)
{
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        arrayOfNumbers[i] *= -1;
    }
    return arrayOfNumbers;
}

int[] arrayOfNumbers = GetArray(10, 9);
Console.Write("Исходный массив: ");
PrintArray(arrayOfNumbers);

int[] modArray = ModifiedArray(arrayOfNumbers);
Console.Write("Измененный массив: ");
PrintArray(modArray);