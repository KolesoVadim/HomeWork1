// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine()??"0");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {i*i*i}");
}