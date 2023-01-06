// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// максимальным и минимальным значением элементов массива.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3...хотя почему 3, когда вроде 4 получается..???...
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целые числа;
// - CreateRealArray() - Метод инициализации массива вещественных чисет;
// - FillArrayConsoleDouble - Метод заполнения массива вещественных чисел;
// - PrintRealArrwithHeader() - Метод вывода содержимого массива на консоль с печатью заголовка (текстовой строки);
// - PrRealArrayInLine() - Метод вывода одномерного массива на печать в строки по N элементов,;
//                      но не больше,чем по 10 чисел в строке (вызывается из PrintRealArrwithHeader);
// - HappyNewYear() - Метод вывода на консоль рождественского поздравления (прогрессирующая текстовая строка, 
//                  с буквами разных цветов, подобранных по определенной  гамме)
//
string End = "Y";

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число элементов массива");

    if (N < 1) Console.WriteLine("Число не может быть меньше 1");
    else
    {
        double[] MyArray = CreateRealArray(N);   // инициализация массива
       
        if (FillArrayConsoleDouble(MyArray, false))
        {
            // Подсчет количества положительных элементов массива
            int kGTZero = 0;
            int i = 0;

            while (i < N)
            {
                if (MyArray[i] > 0) kGTZero++;
                i++;
            }


            Console.Clear();
            Console.WriteLine(">>>>>>>---->>>>>>");
            PrintRealArrwithHeader("Распечатаем введенный массив чисел", MyArray);
            Console.WriteLine('\n' + $"Введено чисел: {N,2}" + '\n' + $"Из них больше нуля: {kGTZero,2}");
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

    }

    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}
 string[] stringArray = { "С", " ", "Р", "О", "Ж", "Д", "Е", "С", "Т", "В", "О", "М", " ", "Х", "Р", "И", "С", "Т", "О", "В", "Ы", "М", "!", "0" };

        HappyNewYear(stringArray);  //   вывод на консоль рождественского поздравления.