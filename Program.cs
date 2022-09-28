//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Enter 1st number");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2st number");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"{numberA} MORE then {numberB}");
}
else
{
    if(numberA == numberB)
    {
        Console.WriteLine($"{numberA} and {numberB} are EQUAL");
    }
    else
    {
        Console.WriteLine($"{numberA} LESS then {numberB}");
    }
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Enter THREE numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2 & number1 > number3)
{
    Console.WriteLine($"{number1} is maximum number");
}
if(number2 > number3 & number2 > number1)
{
    Console.WriteLine($"{number2} is maximum number");
}
if(number3 > number1 & number3 > number2)
{
    Console.WriteLine($"{number3} is maximum number");
}
else
{
    Console.WriteLine("You entered two or more EQUAL numbers. Please, reenter different numbers!");
}
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Enter number:");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.WriteLine($"Entered number {numberA} is EVEN");
}
else
{
    Console.WriteLine($"Entered number {numberA} is ODD");
}
*/
// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;

while(counter <= number)
{
    if(counter % 2 == 0)
    {
        Console.WriteLine(counter + " ");
    }
counter ++;
}
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//1423 % 10 = 3
//1423 % 100 = 23
//1423 % 1000 = 423

//1423 / 10 = 142
//1423 / 100 = 14
//1423 / 1000 = 1

/*
Console.WriteLine("Enter three-digits number");
int number = Convert.ToInt32(Console.ReadLine());
int MediumNumber(int number)
{
    int iteration1 = number % 10;
    int iteration2 = number / 100;
    int result = (number - iteration2 * 100 - iteration1)/10;
    return result;
}
int method = MediumNumber(number);
Console.WriteLine($"Result is {method}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Enter an integer");
int number = Convert.ToInt32(Console.ReadLine());

int MediumNumber(int number)
{
    int result = number % 10;
    return result;
}
void ReverseNumber(int number)
{
    string str = number.ToString();
    Console.WriteLine(str[2]);
}

if(number > 99 & number < 1000)
{
    int method = MediumNumber(number);
    Console.WriteLine($"The third digit is {method}");
}
    if(number > 999)
    {
        ReverseNumber(number);
    }
        if(number < 100)
        {
            Console.WriteLine("The THIRD DIGIT IS MISSING");
        }
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Enter number of the day of week (from 1 to 7):");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 6 & number <= 7)
{
    Console.WriteLine($"Your number {number} is a weekend");
}
else
{
    if(number > 0 & number < 6)
    {
        Console.WriteLine($"Your number {number} is a working day");
    }
    else
    {
        Console.WriteLine($"Your number {number} is OUT OF RANGE");
    }
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine(" What`s your name, comrade?: ");
string? name = Console.ReadLine();
Console.WriteLine($" Hi, {name}! Enter your number: ");
long number = Convert.ToInt64(Console.ReadLine());

long numberReversed = 0;
long numberOriginal = number;

while (number > 0)
{
    long currentDigit = number % 10;
    numberReversed = numberReversed * 10 + currentDigit;
    number = number / 10;
}

//Console.WriteLine($"{numberOriginal} {numberReversed}"); // для проверки корректности реверса числа

if(numberOriginal == numberReversed)
{
    Console.WriteLine($"O, {name}! Congratulation!!! Your number {numberOriginal} is palindrome!!!");    
}
else
{
    Console.WriteLine($"{name}, it`s bad news for you.... Your number {numberOriginal} is NOT palindrome..... I`m sorry.");
}
*/
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x3d = ((x2 - x1) * (x2 - x1));
    double y3d = ((y2 - y1) * (y2 - y1));
    double z3d = ((z2 - z1) * (z2 - z1));
    double midRes = x3d + y3d + z3d;
    double res3d = Math.Sqrt(midRes);
    return res3d;
}

Console.Write(" Enter X dot No.1 ");
    double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter Y dot No.1 ");
    double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter Z dot No.1 ");
    double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter X dot No.2 ");
    double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter Y dot No.2 ");
    double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter Z dot No.2 ");
    double z2 = Convert.ToDouble(Console.ReadLine());

double distance3D = FindDistance3D (x1, y1, z1, x2, y2, z2);
Console.WriteLine($" Distance is {distance3D}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine(" Enter Number: ");
int number = Convert.ToInt32(Console.ReadLine());

void FindCube(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(counter * counter * counter + " ");
        counter++;
    }
}
FindCube(number);
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Enter Number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberAOriginal = numberA;
int counter = 1;
int numberC = 1;

while(counter <= numberB)
    {
        numberC = numberC * numberA;
        counter++;
    }

Console.WriteLine($"The number {numberA} to the power of {numberB} equals {numberC}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
int length = str.Length;
int sum = 0;

//Console.WriteLine(length);

for(int i = 0; i <= length-1; i++)
{
    int result = str[i]-'0';
    sum = sum + result;
}
    Console.WriteLine($"The sum of the digits NUMBER is {sum}");
*/
/////////Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Write("Enter the size of the array:\t");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Enter the element of the array with Index {i}:\t");
    myArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Array output:");
for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i] + " ");
}
*/

// HomeWork05

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
/////////////////////которая покажет количество чётных чисел в массиве.
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
/*
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

double[] myArray = CreateRandomArray(5, 0, 9);
double minElement = myArray[0];
double maxElement = myArray[0];

ShowArray(myArray);

for(int i = 0; i <= myArray.Length-1; i++)
{
    if(myArray[i] <= minElement) minElement = myArray[i];
    else if(myArray[i] >= maxElement) maxElement = myArray[i];
}
double result = maxElement - minElement;
Console.WriteLine($"Result between Max {maxElement} & Min {minElement} numbers is {result}");
*/


///////Задача 41: Пользователь вводит с клавиатуры M чисел. 
//////////////////Посчитайте, сколько чисел больше 0 ввёл пользователь.(решать без массивов)
/*
Console.Write("Enter, please, some numbers with space: ");
string? userNumbers = Convert.ToString(Console.ReadLine());

int countNumbers = 1;
int countMinus = 0;
for (int i = 0; i < userNumbers?.Length; i++)
    {
        if ((userNumbers[i] == ' ')) countNumbers++;
    }
    //Console.WriteLine("In the string is {0} word('s).", countNumbers);

for (int i = 0; i < userNumbers?.Length; i++)
    {
        if ((userNumbers[i] == '-')) countMinus++;
    }
    //Console.WriteLine("Count Minus is {0}", countMinus);

int result = countNumbers - Convert.ToInt32(countMinus);
Console.WriteLine($"Amount of numbers greater than '0' is {result}");
*/
//Второй вариант решения задачи (как говорится, просто чтобы решить и подогнать под ответ :)/////
/*
Console.WriteLine("Enter 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3rd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 4th number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 5th number: ");
int num5 = Convert.ToInt32(Console.ReadLine());

int counter = 0;
int num = num1;

if (num1 > 0) counter++;
if (num2 > 0) counter++;
if (num3 > 0) counter++;
if (num4 > 0) counter++;
if (num5 > 0) counter++;

Console.WriteLine($"{counter} number(s) entered by User above '0'");
*/
///////Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//////////////////значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Enter value k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int x = 0;
int y = 0;

void Intersection (int k1, int b1, int k2, int b2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

int FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0 ) return 1;
    if(x < 0 && y > 0 ) return 2;
    if(x < 0 && y < 0 ) return 3;
    if(x > 0 && y < 0 ) return 4;
    return 0;
}

if (k1 == k2)
{
    Console.WriteLine("Lines are parallel");
}
else
{
    Intersection(k1, b1, k2, b2);
    int quadrant = FindQuadrant(x, y);
    Console.WriteLine($"Point of intersection is x={x}, y={y} \nAnd this point is in the {quadrant} quadrant");
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    //for (int i = 0; i < newArray.GetLength(0))
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
////////////////или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    //for (int i = 0; i < newArray.GetLength(0))
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

Console.Write("Enter index number [i]: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter index number [j]: ");
int indexJ = Convert.ToInt32(Console.ReadLine());

if (indexI >= rows || indexJ >= columns)
{
    Console.WriteLine($"No index value at address {indexI},{indexJ}");
}
else
{
    Console.WriteLine($"Value of array`s element with address [{indexI},{indexJ}] is number {myArray[indexI, indexJ]}.");
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] newArray = new double[rows, columns];

//     //for (int i = 0; i < newArray.GetLength(0))
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray (rows, columns, minValue, maxValue);
// Show2dArray(myArray);

// Console.Write("Enter No. of a column: ");
// int numberColumn = Convert.ToInt32(Console.ReadLine());

// double AverageSumColumn (double[,] myArray)
// {
//     int i = 0;
//     double sum = 0;
//     while (i < rows && numberColumn < columns)
//     {
//         sum += myArray[i,numberColumn];
//         i++;
//     }
//     return sum / rows;
// }

// if (numberColumn >= columns) 
// {
//     Console.WriteLine($"Does not exist!. Min '0' (first column), Max '{columns - 1}' (last column).");
// }
// else
// {
//     Console.WriteLine($"Average sum on the column No.{numberColumn} is {AverageSumColumn(myArray)}");
// }

////////////////////Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Enter number of rows: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter number of columns: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter min of array: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter max of array: ");
//     int max = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[m, n];

//     //for (int i = 0; i < newArray.GetLength(0))
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i,j] = new Random().Next(min, max + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
// }

// void DescArrayElementsInRows (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array [i,k] < array [i,k + 1])
//                 {
//                     int temp = array[i,k];
//                     array[i,k] = array[i,k + 1];
//                     array[i,k + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// Console.WriteLine("\nArray after iterations:");
// DescArrayElementsInRows(newArray);
// Show2dArray(newArray);

////////////////////Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of colums: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] newArray = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
//         }
//     }
    
//     return newArray;
// }

// void ShowArray2d(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindMinSumElementsLine(int[,] array) 
// {
//     int row = 0;
//     int min = 0; 
//     for(int j = 0; j < array.GetLength(1); j++)
//         min = array[0, j] + min;   
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//             sum = array[i,j] + sum;
//     if(sum < min)
//     {
//         min = sum;
//         row = i;
//     }
//     }
//     Console.WriteLine($"The line with the minimum sum of array`s elements is {row + 1}");
// }

// int[,] myArray = CreateRandom2dArray();
// ShowArray2d(myArray);
// FindMinSumElementsLine(myArray);

////////////////////Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
//         }
//     }
    
//     return newArray;
// }
// void ShowArray2d(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] ArraysMultiplicationResult(int[,] array1, int[,] array2)
// {
//     int[,] newArray = new int[array1.GetLength(0), array1.GetLength(1)];
//     for(int i = 0; i < array1.GetLength(0); i++)
//         for(int j = 0; j < array1.GetLength(1); j++)
//             for(int k = 0; k < array1.GetLength(1); k++)
//             {
//                 newArray[i,j] += array1[i,k] * array2[k,j];
//             }
//     return newArray;
// }
// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] newArray1 = CreateRandom2dArray(m, n, min, max);
// ShowArray2d(newArray1);
// int[,] newArray2 = CreateRandom2dArray(m, n, min, max);
// ShowArray2d(newArray2);
// ShowArray2d(ArraysMultiplicationResult(newArray1, newArray2));

////////////////////Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//////////////////////////////которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray()
// {
//     Console.Write("Input length (5): ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input wide (4): ");
//     int wide = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input height (4): ");
//     int height = Convert.ToInt32(Console.ReadLine());

//     int[,,] newArray = new int[length, wide, height];
//     int[] checkarray = new int[90];
//     int count = 0;
//     int temp = 9;
//     int index = 0;
    
//     if (length * wide * height < 90)
//     {
//         for(int i = 0; i < length; i++)
//         {
//             for(int j = 0; j < wide; j++)
//             {
//                 for(int z = 0; z < height; z++)
//                 {   
//                     temp = new Random().Next(10, 99);
        
//                     for (int current = 0; current < 90; current++)
//                     {
//                         if (checkarray[current] == temp) count = 1;
//                     }

//                     if (count == 0) 
//                     {  
//                         newArray[i, j, z] = temp;
//                         checkarray[index + 1] = temp;
//                     }
//                 }   
//             }
//         }
//     }
//     return newArray;
// }

// void ShowArray3d(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//                 {
//                     Console.Write(array[i, j, k]);
//                     Console.Write($"({i}, {j}, {k}) ");
//                 }
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }


// int[,,] userArray = CreateRandom3dArray();
// ShowArray3d(userArray);

////////////////////Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Enter rows numbers: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns numbers: ");
int columns = Convert.ToInt32(Console.ReadLine());

int w = 1;

int [,] array = new int [rows, columns];

for (int y = 0; y < columns; y++)
{
    array [0,y] = w;
    w++;
}

for (int x = 1; x < rows; x++)
{
    array [x, columns - 1] = w;
    w++;
}

for (int y = columns - 2; y >= 0; y--)
{
    array [rows - 1, y] = w;
    w++;
}

for (int x = rows - 2; x > 0; x--)
{
    array [x, 0] = w;
    w++;
}

int c = 1;
int d = 1;

while (w < rows * columns)
{
    while (array [c, d + 1] == 0)
    {
        array [c,d] = w;
        w++;
        d++;
    }

    while (array[c + 1, d] == 0) 
    {
        array[c, d] = w;
        w++;
        c++;
    }
 
    while (array[c, d - 1] == 0) 
    {
        array[c, d] = w;
        w++;
        d--;
    }
 
    while (array[c - 1, d] == 0) 
    {
        array[c, d] = w;
        w++;
        c--;
    
    }

    for (int x = 0; x < rows; x++) 
    {
        for (int y = 0; y < columns; y++) 
        {
            if (array[x, y] == 0) 
            {
                array[x, y] = w;
                w++;
            }
        }
    }


    for (int x = 0; x < rows; x++) 
    {
        for (int y = 0; y < columns; y++) 
        {
            if (array[x, y] < 10) 
            {
                Console.Write(array[x, y] + ",  ");
            }    
            else 
            {
                Console.Write(array[x, y] + ", ");
            }
        }  
        Console.WriteLine("");
    }
}
