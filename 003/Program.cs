// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("ENTER NUMBER: ");
int number = int.Parse(Console.ReadLine()??"0");
if (number % 2 == 0)
{
    Console.Write("number kratno");
}
else
{
    Console.Write("net");
}