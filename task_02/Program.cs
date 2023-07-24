/* Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет. (Если решаете математически максимум берем 100000)*/

int rnd = new Random().Next(100000);
//int rnd = 9876;
Console.WriteLine(rnd);
if (rnd <= 99) {
  Console.WriteLine("Третьей цифры нет");
}
if (rnd < 1000) {
  int a = rnd%10;
  Console.WriteLine($"Третья цифра числа {rnd} - {a}");
}

if (rnd < 10000 && rnd >= 1000) {
  int a = rnd/10;
  int b = a%10;
  Console.WriteLine($"Третья цифра числа {rnd} - {b}");
}

if (rnd < 100000 && rnd >= 10000) {  //99 999
  int a = rnd/100;
  int b = a%10;
  Console.WriteLine($"Третья цифра числа {rnd} - {b}");
}