// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("enter A: ");
int A = int.Parse(Console.ReadLine()??"0");
Console.Write("enter B: ");
int B = int.Parse(Console.ReadLine()??"0");
Console.Write("enter C: ");
int C = int.Parse(Console.ReadLine()??"0");
int max=A;
if (B > max) max=B;
if (C > max) max=C;
Console.Write("max = ");
Console.WriteLine(max);