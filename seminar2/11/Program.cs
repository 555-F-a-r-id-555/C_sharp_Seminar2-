// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int num = Random.Shared.Next(100, 1000);
Console.WriteLine(num);
int first = num / 100;
// Console.WriteLine(first);
int last = num % 10;
// Console.WriteLine(last);
int result = first * 10 + last;

Console.WriteLine($"{num} -> {result}");

