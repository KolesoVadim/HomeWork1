// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Ведите трёхзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int second = (number / 10 % 10);
Console.WriteLine("Вторая цифра трёхзначного числа: " + second);