//Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Enter first number: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int numB = int.Parse(Console.ReadLine());
int max = numA;
if(numA<numB)
{
    max = numB;
    Console.WriteLine($"a = {numA}, b = {numB} -> max = {max}");
}
else
{
    Console.WriteLine($"a = {numA}, b = {numB} -> max = {max}");
}