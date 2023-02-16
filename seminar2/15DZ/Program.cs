// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


int day = Convert.ToInt16(Console.ReadLine());
string dayoff = (day == 6 || day == 7) ? "да" : "нет";
string error = (day <= 0 || day > 7) ? "ошибка ввода" : dayoff;

Console.WriteLine($"{day} -> {error}");

// Проверка ;
// void res()
// {
//     for (int i = 0; i < 10; i++)
//     {
//         int day = i;
//         string dayoff = (day == 6 || day == 7) ? "да" : "нет";
//         string error = (day <= 0 || day > 7) ? "ошибка ввода" : dayoff;

//         Console.WriteLine($"{day} -> {error}");
//     }
// }
// res();