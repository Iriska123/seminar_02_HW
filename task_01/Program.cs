﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное  и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456 -> 5
782 -> 8
918 -> 1*/


Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($" Вы ввели число - {num}");


if(num / 100 >= 1 && num / 100 < 10) {
  Console.WriteLine("Число трехзначное ");
  int x = num/10;
  int x2 = x%10;
  Console.WriteLine($"вторая цифра - {x2} ");

} else{
  Console.WriteLine("Число не трехзначное ");
}
