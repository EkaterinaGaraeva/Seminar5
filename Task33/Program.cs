/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool SpecifiedNumber(int number, int[] arrayOfNumbers)
{
    bool isInArray = false;
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] == number)
        {
            isInArray = true;
            break;
        }
        else
        {
            isInArray = false;
        }
    }
    return isInArray;
}

int[] arrayOfNumbers = GetArray(10, 9);
Console.Write("Исходный массив: ");
PrintArray(arrayOfNumbers);

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool x = SpecifiedNumber(num, arrayOfNumbers);
Console.WriteLine(x);
