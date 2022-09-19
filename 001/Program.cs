// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("ENTER NUMBER A: ");
int A = int.Parse(Console.ReadLine()??"0");
Console.Write("ENTER NUMBER B: ");
int B = int.Parse(Console.ReadLine()??"0");
if (A > B)
{
    Console.WriteLine("number A BIG");
}
else
{
    Console.WriteLine("number B BIG");
}