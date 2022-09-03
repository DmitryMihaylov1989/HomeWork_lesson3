// Задача 19: Напишите программу, которая принимает на
//  вход пятизначное число 
//  и проверяет, 
//  является ли оно палиндромом.
Console.WriteLine("Введите целое, пятизначное число");
int num = Convert.ToInt32(Console.ReadLine()),result = 0;
int square=(num); 
int a = num % 10;
num = num / 10;
result += a * 10000;

a = num % 10;
num = num / 10;
result += a * 1000;

a = num % 10;
num = num / 10;
result += a * 100;

a = num % 10;
num = num / 10;
result += a * 10;

a = num % 10;
num = num / 10;
result += a;
if (square==result) Console.WriteLine($"число {square} - палиндром");
else Console.WriteLine($"число {square} - не палиндром");

