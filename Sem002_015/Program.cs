// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.6, 7 - выходной.
// 6 -> да
// 7 -> да
// 1 -> нет
//
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанный ранее метод 
// - DisplayReplyInt() - ввод целого числа с терминала
// - PosLeftToRight() - возвращает числовое значение, соответствующее
// -  DigitsInNumber() - возвращает количество цифр (десфтичных разрядов) в числе
//     цифре в указанном слева десятичном разряде
int N;

int nPosLeftToRight, totaldigs, DigitInPos;

string End = "Y";

while (End != "N")
{
    N = DisplayReplyInt("Введите целое число: ");

    totaldigs = DigitsInNumber (N);

    if (totaldigs = 1 ) 

    {
        nPosLeftToRight = 1;   // Берется первая слева цифра от числа
        
        DigitInPos = PosLeftToRight(N, nPosLeftToRight);

            Console.WriteLine("Продолжить обработку (Y/N");

    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

    }   
else   // если в числе больше одной цифры, то выдается сообщение об ошибке
{
Console.WriteLine("Число введено с ошибкой - должно содержать только одну цифру. Продолжить обработку (Y/N)");
Console.WriteLine("Продолжить обработку (Y/N)");   
End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;
}

}
