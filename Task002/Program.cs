/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Enter first number: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int numC = int.Parse(Console.ReadLine());
int max = numA;
if(max < numB)
{
    max = numB;
    Console.WriteLine($"{numA}, {numB}, {numC} -> {max}");
}
else if(max < numC) // НЕ работает Почему??
{
    max = numC;
    Console.WriteLine($"{numA}, {numB}, {numC} -> {max}");
}
else
    Console.WriteLine($"{numA}, {numB}, {numC} -> {max}");