// Задача 29. Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
// и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//
// N: 3 [9, 4, 12] => 2097
// 
//   Для проверки можно использовать https://numsys.ru/convert/2097/10/15
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyDouble() - Метод ввода/вывода с терминала числа типа double;
// - DisplayReplyString() - Метод ввода/вывода с терминала текстовой строки;
// - PrintArrayInLine() - Метод вывода одномерного массива на печать в строки по N элементов, 
//                      но не больше,чем по 10 чисел в строке
//
//
string End = "Y";

int sBase = 16;

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число элементов массива");

    if (N < 1)
    {
        Console.WriteLine("Число не может быть меньше 1");
    }
    else
    {
        int[] MyArray = CreateIntArray(N);   // инициализация массива

        FillArray (MyArray, 0,14);  //  заполнение массива случайными числами в диапазоне от 0 до 14

        PrintArrayInLine(MyArray, 10);     //  вывод массива на консоль

        if (ConvertNumber (MyArray, sBase, out string NumberInString, out int NumberInDec))
        {
            Console.WriteLine(">>>>>>>---->>>>>>");
            Console.Writeline();
            Console.Writeline ('/n' + $"Значение числа в {sBase,2}-ричной системе: {NumberInString,3}")
            Console.Writeline ('/n' + $"Значение числа в десятичной системе: {NumberInDec,3}")
        }

        End = DisplayReplyString("Продолжить обработку (Y/N");
        if (End == "n") break;
        if (End == "т") break;
        if (End == "Т") break;
        if (End == "N") break;
    }
}
