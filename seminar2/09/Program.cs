// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int num = Random.Shared.Next(10, 100);
Console.WriteLine(num);

int res = (num / 10 > num % 10) ? num / 10 : num % 10;
Console.WriteLine($"{num} -> {res}");