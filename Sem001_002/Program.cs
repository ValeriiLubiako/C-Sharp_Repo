//Задача 2: Напишите программу, которая на вход принимает (целое) число
//       и выдает, является ли число четным (делится ли оно на два без остатка)
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанный ранее методы 
//  - DisplayReplyInt() - ввод целого числа с терминала
//  - EvenOdd(a) - определение четности числа
int a;
string End = "Да";

while (End != "N")
{
a = DisplayReplyInt("Введите целое число");


if (EvenOdd(a)) Console.WriteLine($"{a,3}" + " является четным");
else Console.WriteLine($"{a,3}" + " является НЕчетным");
Console.WriteLine("Продолжить проверку (Y/N");
End = Console.ReadLine(); 
if (End == "n") break;
if (End == "т") break;
if (End == "Т") break;

}


