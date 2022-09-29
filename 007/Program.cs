// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine()??"0");
int first = number / 10000;
int second = number % 10000 / 1000;
int fourth = number % 100 / 10;
int fifth = number % 10; 
if  ((first == fifth) & (second == fourth))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}