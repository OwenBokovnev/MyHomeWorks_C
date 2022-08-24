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
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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