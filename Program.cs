//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

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
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Enter THREE numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int numMax = 0;

if(number1 > numMax)
{
    Console.Write(numMax == number1);
}
    if(number2 > numMax);
    {
        Console.Write(numMax == number2);
    }
Console.Write(numMax == number3);