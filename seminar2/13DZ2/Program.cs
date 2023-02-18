/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


void my_function(int num)
{
    int num1 = num;
    if (num1 >= 100)
    {
        for (int i = 10; num1 / i >= 100;) num1 = num1 / i;
        Console.WriteLine($"{num} -> {num1 % 10}");
    }
    else Console.WriteLine($"{num} -> третьей цифры нет");
}

my_function(0);
my_function(2);
my_function(78);
my_function(100);
my_function(845);
my_function(1000);
my_function(1040);
my_function(32579);
my_function(326879);
my_function(3271679);
my_function(34800000);
my_function(659000300);
