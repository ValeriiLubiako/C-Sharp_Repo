// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельзя
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целого числа;
// - DigitsInNumber() - Метод определения количества цифр в целои числе;
// - DisplayReplyString() - Метод ввода с термина строки символов.
//
//
string End = "Y";

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число");

    int SumOfDigits = 0;

    int NumberOfDigits = DigitsInNumber(N, out SumOfDigits);


    Console.WriteLine(">>>>>>");
    Console.WriteLine($"Введено число: {N,3}, количество цифр: {NumberOfDigits,3}");
    Console.WriteLine($"Сумма цифр составляет:  {SumOfDigits,3}");
    Console.WriteLine();

    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}




