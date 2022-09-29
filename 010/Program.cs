// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Enter number A: ");
int A = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter number B: ");
int B = int.Parse(Console.ReadLine()??"0");
int result = 1;
for (int i = 0; i < B; i++)
{
result = result * A;
}
Console.WriteLine("A в степени B равно: " + result);