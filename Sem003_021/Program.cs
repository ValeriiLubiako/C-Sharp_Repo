// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//
// A (0,0); B (1,1), -> ~1.4
// A (2,4); B (0,7) -> ~3.6
//
//
using static MyLibrary;   //  ссылка на библиотеку
//
// - используем написанные ранее методы
// - DisplayReplyDouble() - Метод ввода/вывода с терминала числа типа double;
// - DisplayReplyString() - Метод ввода/вывода с терминала текстовой строки;
// 
//  
//
string End = "Y";

while (End != "N")
{

double X1 = DisplayReplyDouble ("Введите координату X первой точки");

double Y1 = DisplayReplyDouble ("Введите координату Y первой точки");

double X2 = DisplayReplyDouble ("Введите координату X второй точки");

double Y2 = DisplayReplyDouble ("Введите координату Y второй точки");



double Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Distance}");

 End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}


