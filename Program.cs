// HomeWork05

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int i = 0;
int count = 0;
int[] myArray = CreateRandomArray(10, -999, 999);
ShowArray(myArray);

for (i = 0; i <= myArray.Length-1; i++)
{
    if(myArray[i] % 2 == 0)
    {
        count++;
        //Console.WriteLine($"Count of the EVEN numbers is {count}:\t");
    }
}
Console.WriteLine($"Count of the EVEN numbers is {count}:\t");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int i = 0;
int sum = 0;
int[] myArray = CreateRandomArray(4, 0, 10);

for(i = 0; i <= myArray.Length-1; i++)
{
    if(i % 2 != 0)
    {
        sum = sum + myArray[i];
    }
}
ShowArray(myArray);
Console.WriteLine($"Sum of value ODD indexes is {sum}:\t");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

//int i = 0;
//int maxElement = 0;
//int minElement = 0;

double[] myArray = CreateRandomArray(10, 0, 10);

ShowArray(myArray);

