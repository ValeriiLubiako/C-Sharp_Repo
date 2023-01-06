// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - CreateRealArray() - Метод инициализации массива вещественных чисет;
// - FillArrayConsoleDouble() - Метод заполнения массива вещественных чисел значениями, вводимыми через консоль;
// - PrintRealArrwithHeader() - Метод вывода содержимого массива на консоль с печатью заголовка (текстовой строки);
// - DisplayReplyString() - Метод ввода с терминала строки символов;
// - HappyNewYear() - Метод вывода на консоль рождественского поздравления (прогрессирующая текстовая строка, 
//                  с буквами разных цветов, подобранных по определенной  гамме)
//

string End = "Y";


while (End != "N")
{

    // string Tokenstr = DisplayReplyString("Введите через пробел коэффициенты системы уравнений - b1 k1 b2 k2");

    Console.WriteLine("Введите через пробел коэффициенты системы уравнений - b1 k1 b2 k2");


    double[] MyArray = CreateRealArray(4);   // инициализация массиваy


    if (FillArrayConsoleDouble(MyArray, false))
    {
        //   Решая систему уравнений, получаем следующее выражение для вычисления x=(b2-b1)/(k1-k2)
        //   а y=k1*x+b1

        // ДЛя большей наглядности кода, писвоим значения коэффициентов системы уравнений следующим переменным:

        double b1 = MyArray[0];
        double k1 = MyArray[1];
        double b2 = MyArray[2];
        double k2 = MyArray[3];



        // Вычисляем значение координат точки пересечения

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.Clear();
        Console.WriteLine(">>>>>>>---->>>>>>");

        PrintRealArrwithHeader("Введенный массив коэффициентов (b1,k1,b2,k2):", MyArray);
        if (k1 == k2) Console.WriteLine('\n' + $"При условии k1=k2 задача не имеет решения (деление на ноль)");
        else Console.WriteLine('\n' + $"Координаты точки пересечения: X=" + $"{x}" + " Y=" + $"{y}");

    }
    else
    //  Выдача сообщения об аварийной ситуации и возврат на следующий цикл (ввод длины массива)
    {

        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        Console.ForegroundColor = colors[10];

        Console.WriteLine(">>>>>>>---->>>>>>");
        Console.WriteLine('\n' + $"АВАРИЙНОЕ ЗАВЕРШЕНИЕ ВВОДА ДАННЫХ (ESC)!");
        Console.ResetColor();
        PrintRealArrwithHeader("Распечатываем возвращаемый массив (Esc)", MyArray);
        break;
    }



    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;
}
 string[] stringArray = { "С", " ", "Р", "О", "Ж", "Д", "Е", "С", "Т", "В", "О", "М", " ", "Х", "Р", "И", "С", "Т", "О", "В", "Ы", "М", "!", "0" };

        HappyNewYear(stringArray);  //   вывод на консоль рождественского поздравления.