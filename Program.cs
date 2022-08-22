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

Console.WriteLine("Enter number:");
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
