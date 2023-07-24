// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным. (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)


Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num);

switch (num) {

  case 1:
    Console.WriteLine("Это рабочий день");
    break;
  case 2:
    Console.WriteLine("Это рабочий день");
    break;
  case 3:
    Console.WriteLine("Это рабочий день");
    break;
  case 4:
    Console.WriteLine("Это рабочий день");
    break;
  case 5:
    Console.WriteLine("Это рабочий день");
    break;
  case 6:
    Console.WriteLine("ВЫХОДНОЙ!!!");
    break;
  case 7:
    Console.WriteLine("ВЫХОДНОЙ!!!");
    break;
  default:
    Console.WriteLine("Такого дня в неделе нет!");
    break;
}