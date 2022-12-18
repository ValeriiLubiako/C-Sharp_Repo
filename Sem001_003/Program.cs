//Задача 3: Напишите программу, которая на вход принимает (целое) число (N),
//       а на выходе показывает все четные числа от 1 до N
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанные ранее методы 
//  - DisplayReplyInt() - ввод целого числа с терминала
//  - EvenOdd(a) - определение четности числа
//  - CreateIntArray - создание массива целых чисел
//  - PrintArrayInLine(array, K)  - вывод на консоль элементов массива построчно, по к
//  -   элементов в строке
//
int N;
string End = "Да";

while (End != "N")
{
    N = DisplayReplyInt("Введите целое число");



    int size = N - 1;

    if (EvenOdd(N)) size = N / 2;  // количество четных значений элементов массива
    else size = (N - 1) / 2;   // для четного и нечетного N

    int[] array = CreateIntArray(size);  // создаем массив под четные значения

    int j = 1;
    int i = 1;
    while (i <= N)   // формируем массив из четныз чисел
    {
        if (EvenOdd(i))
        {
            array[j - 1] = i;
            j++;
        }
        i++;

    }

    Console.WriteLine();
    Console.WriteLine();

    // Распечатыываем массив используя метод построчной печати с выводом 
    // заданного количества элементов в строке, наример 10


    PrintArrayInLine(array, 10);

    if (N == 1) Console.WriteLine("Нет ни одного четного числа!!!");

    Console.WriteLine("Продолжить проверку (Y/N");
    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;

}
