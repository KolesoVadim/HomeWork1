// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
string str = Console.ReadLine()??"0";
 if(str.Length >= 3)
 {
     Console.WriteLine(str[2]);
 }
 else
 {
     Console.WriteLine("Третьей цифры нет");
 }