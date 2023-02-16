/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


void my_function(int num)
{
    if (num / 100 != 0) Console.WriteLine($"{num} -> {(num / 100) % 10}");
    else Console.WriteLine($"{num} -> третьей цифры нет");
}
my_function(0);
my_function(2);
my_function(78);
my_function(845);
my_function(32679);
my_function(650000300);

Console.WriteLine($"5031 -> {(5031 / 100) % 10}"); // Это пример;