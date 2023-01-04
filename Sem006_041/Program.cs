// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// максимальным и минимальным значением элементов массива.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целые числа;
// - CreateRealArray() - Метод инициализации массива вещественных чисет;
// - FillRealArray() - Метод заполнения массива случайными целыми числами из заданного диапазона значений;
// - PrRealArrayInLine() - Метод вывода одномерного массива на печать в строки по N элементов,;
//                      но не больше,чем по 10 чисел в строке;
// - HappyNewYear() - Метод вывода на консоль новогоднего поздравления;
// - DisplayReplyString() - Метод ввода с термина строки символов
//
// using System;
// class Example
// {
// public static void Main()
// {
// using System;

// class Example
// {
//    public static void Main()
//    {
// namespace System
// {
//     public static class Console 
//     {
//         void GetCursorPosition(out int left, out int top);
//     }
// }
//    
ConsoleKeyInfo cki;
// Prevent example from ending if CTL+C is pressed.
Console.TreatControlCAsInput = true;   // Блокируем выход по CTRL+C, останутся только по Esc и Enter


Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
Console.WriteLine("Press the Escape (Esc) key to quit: \n");

string[] ab = new string[150];
int i = 0;
string StringFromConsole = string.Empty;
string ckiKeyToString = string.Empty;

string[] ConsoleReadKeyValues = { "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "Oem2", "OemPeriod", "OemMinus", "Spacebar", "Enter", "Escape" };

int k = 100;

Console.Clear();
int origRow = Console.CursorTop;
int origCol = Console.CursorLeft;
int colPos = origCol;
string ConsoleString = string.Empty;
int kswitch = 1000;

do
{

    // origRow = Console.CursorTop;
    // origCol = Console.CursorLeft;

    // Console.WriteLine($"origRow= {origRow,3} origCol= {origCol,3}");

    cki = Console.ReadKey();

    // Console.Write(" --- You pressed ");
    // if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
    // if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
    // if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
    // Console.WriteLine(cki.Key.ToString());


    // Console.Write(StringFromConsole);

    ckiKeyToString = cki.Key.ToString();

    kswitch = 10000;    // если не является допустимым символом, то возвращается необрабатываемое в switch значение
    for (int j = 0; j < 16; j++)
    {
        if (ckiKeyToString == ConsoleReadKeyValues[j])
        {
            kswitch = j;
            break;
        }

    }

    // Console.WriteLine($"kswitch= {kswitch,3} ckiKeyToString= {ckiKeyToString,3}");
    switch (kswitch)

    {
        case 0:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 1:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 2:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 3:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 4:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 5:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 6:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 7:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 8:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 9:
            StringFromConsole = kswitch.ToString();
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 10:
            StringFromConsole = ".";
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 11:
            StringFromConsole = ".";
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 12:
            StringFromConsole = "-";
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 13:
            StringFromConsole = " ";
            ConsoleString = ConsoleString + StringFromConsole;
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 14:
            // StringFromConsole = "Enter";
            ab[i] = cki.Key.ToString();
            i++;
            break;
        case 15:
            // StringFromConsole = "Escape";
            ab[i] = cki.Key.ToString();
            i++;
            break;
    }


    // Console.SetCursorPosition (x, y);
    // Console.Write("+");
    // int oldX = 0;
    // int oldY = 0;
    // Console.GetCursorPosition(out  oldX, out oldY);

    // Some console output goes out here

    //   var oldX = Console.CursorLeft;
    //   var oldY = Console.CursotTop;

    // Some console output goes out here


    // Console.SetCursorPosition(oldX, oldY);
    // origRow = Console.CursorTop;
    // origCol = Console.CursorLeft;


    colPos++;
    // Console.Clear();
    // Console.SetCursorPosition(origRow, colPos);
    Console.SetCursorPosition(0, 0);
    // Console.Write($"origRow= {origRow,3} origCol= {origCol,3}");
    Console.Write(ConsoleString);



    if (cki.Key == ConsoleKey.Enter) break;

    // Console.WriteLine(cki.Key);
} while (cki.Key != ConsoleKey.Escape);

// Console.Write(StringFromConsole);
Console.WriteLine($"origRow= {origRow,3} origCol= {origCol,3}");
PrintStringArrayInLine(ab, 10);
