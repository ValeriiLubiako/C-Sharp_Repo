// Библиотека - долой колхоз!!!
//
public static class MyLibrary
{
    //
    // Метод поиска максимального числа из трех целых чисел
    //
    public static int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
    //
    // Метод создания одномерного целочисленного массива с заданным количеством элементов
    //
    public static int[] CreateIntArray(int count)
    {
        return new int[count];
    }
    //
    // Метод создания двумерного целочисленного массива с заданным количеством элементов
    //
    public static int[,] CreateIntArrayTwoDim(int rowcount, int colcount)
    {
        return new int[rowcount, colcount];
    }
    //
    // Метод заполнения одномерного целочисленного массива произвольными числами в 
    // заданном диапазоне значений 
    //
    public static void FillArray(int[] collection, int argmin, int argmax)
    {
        int length = collection.Length;

        int index = 0;

        while (index < length)
        {
            collection[index] = new Random().Next(argmin, argmax);

            //      collection[index] = Random.Shared.Next(argmin, argmax);

            index++;

        }
    }
    //
    // Метод заполнения двумерного целочисленного массива произвольными числами в 
    // заданном диапазоне значений 
    //
    public static void FillArrayTwoDim(int[,] collection, int argmin, int argmax)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount) ;
        { }
        while (j < colcount) ;
        {
            collection[i, j] = new Random().Next(argmin, argmax);

            //      collection[index] = Random.Shared.Next(argmin, argmax);

            j++;

        }
        i++;


    }
    //
    //  Метод вывода одномерного массива на печать в столбик
    //
    public static void PrintArray(int[] arr)
    {
        int count = arr.Length;
        int position = 0;

        while (position < count)

        {
            Console.WriteLine(arr[position]);
            position++;
        }
    }
    //
    //  Метод вывода одномерного массива на печать в строки по N, но не больше,
    //  чем по 10 чисел в строке
    //
    public static void PrintArrayInLine(int[] arr, int Linelength)
    {
        int Llength = 10;

        if (Linelength < 10) Llength = Linelength;

        int count = arr.Length;
        int position = 0;
        int k = 1;

        while (position < count)
        {
            if (k < Llength)
            {
                if (position < count - 1) Console.Write($"{arr[position],3}" + ",");
                else Console.Write($"{arr[position],3}");
            }
            else
            {
                Console.WriteLine($"{arr[position],3}");
                k = 0;
            }
            k++;
            position++;
        }
        Console.WriteLine();
    }
    //
    //  Метод определения меньшего значения индекса элемента одномерного целочисленного массива, 
    //  значение которого равно заданному
    //
    public static int IndexOf(int[] collection, int finn)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1;

        while (index < count)
        {
            if (collection[index] == finn)
            {
                position = index;
                break;
            }
            index++;
        }
        return position;
    }
    //
    //  Метод ввода с термина строки символов
    public static double DisplayReplyDouble(string PromptMessage)
    {
        double DoubleVal = 0;

        Console.WriteLine();
        Console.Write(PromptMessage + ": ");

        DoubleVal = Convert.ToDouble(Console.ReadLine());
        
        return DoubleVal;
    }
    //
    //  Метод ввода с термина строки символов
    public static string DisplayReplyString(string PromptMessage)
    {
        string strVal = String.Empty;

        Console.WriteLine();
        Console.Write(PromptMessage + ": ");

        strVal = Console.ReadLine();

        return strVal;
    }
    //
    //
    //  Метод ввода с терминала целого числа
    //
    public static int DisplayReplyInt(string PromptMessage)
    {
        int intVal = 0;


        Console.Write(PromptMessage + ": ");

        intVal = Convert.ToInt32(Console.ReadLine());



        return intVal;
    }
    //
    //  Метод определяющий четность целого числа
    //
    public static bool EvenOdd(int numberA)
    {
        float b;
        bool result;

        b = numberA % 2;

        if (Math.Abs(b) < 1E-20) result = true;
        else result = false;

        return result;
    }
    //  For future use
    //  Метод определения количества цифр в целои числе
    //  на вход подается целое число
    //  возвращается количество цифр в этом числе

    public static int DigitsInNumber(int numberA)
    {

        int count = 0;

        int n = 0;

        if (numberA < 0) n = numberA * (-1);

        while (n > 0)
        {
            count = count + 1;
            n = n / 10;
        }

        if (numberA == 0) count = 1;

        return count;

    }
    //  For Future use 
    //  Метод помещения цифр целого числа в массив
    //  Возвращает целочисленный массив, значения элементов которого в цифровом выражении
    //  представляют последовательность цифр, из которых составлено число, 
    //  начиная с младшего разряда (т.е. 1-й элемент массива (индекс 0) содержит самую правую цифру числа)
    //  Массив с числом элементов, равным количеству цифр в числе, 
    //  должен быть инициализирован до обращения к методу.
    //  На вход подается число, которое требуется разложить на цифры
    //
    public static void SplitNumberIntoDigitsRightToLeft(int numberA, int[] digArray)
    {


        int i = 0;

        int abnumberA = numberA;

        if (numberA < 0) abnumberA = numberA * (-1);


        while (i != numberA)

        {
            digArray[i] = abnumberA % 10;

            abnumberA = abnumberA / 10;

            i++;

        }

        if (numberA == 0) digArray[0] = 0;

        //   return digArray;
    }
    //
    //  Метод вывода заданной цифры из целого числа
    //  Возвращает цифру (в числовом выражении) в  PosLeftToRight-й слева позиции в числе numberA
    //  Если PosLeftToRight-й цифры в числе нет, возвращается значение -1.
    //
    public static int PosLeftToRight(int numberA, int PosLeftToRight)
    {
        int dLTR = -1;

        if (PosLeftToRight > 0)
        {


            int i = 0;

            int abnumberA = numberA;



            if (numberA < 0) abnumberA = numberA * (-1);


            while (abnumberA != 0)

            {

                abnumberA = abnumberA / 10;

                i++;

            }

            int totaldig = i; //  общее число цифр в числе

            if (numberA < 0) abnumberA = numberA * (-1);
            else abnumberA = numberA;

            if (PosLeftToRight > totaldig)  //  Проверка что номер позиции интересующей цифры        
                                            //  не превышает количества цифр в числе.
                                            // В противном случае вместо значения цифры возвращаем -1.
            {
                dLTR = -1; //  в числе нет указанной цифры - короткое число...
            }
            else
            {

                for (i = 1; i < (totaldig - PosLeftToRight + 1); i++)
                {
                    abnumberA = abnumberA / 10;
                }
                dLTR = abnumberA % 10;

            }
            if (abnumberA == 0) dLTR = 0;


        }
        else
        {
            dLTR = -1;  // номер позиции указан с ошибкой - ноль или отрицат число
        }
        return dLTR;
    }
    //  
    //  Метод возвращающий название дня недели или название - рабочий день или выходной...
    //  На вход подается порядковый номер дня в недели (1-7), параметр, определяющий что возвращать - 
    //  название дня недели и какой это день и параметр, определяющий на каком языке возвращать
    //  указанные значения

    public static string WeekDayName(int wkDaynumber, bool WeekDayName, int lang)
    {

        string wkday = String.Empty;


        string[] arrWeekDaysRus = { "не определен", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        string[] arrDaysRus = { "не определен", "рабочий", "рабочий", "рабочий", "рабочий", "рабочий", "выходной", "выходной" };

        string[] arrWeekDaysEng = { "Undefined", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] arrDaysEng = { "undefined", "workday", "workday", "workday", "workday", "workday", "weekend", "weekend" };

        if (wkDaynumber < 1 | wkDaynumber > 7) wkDaynumber = 0;   //  проверка на ошибочное значение номера дня на входе

        if (lang == 0)    //  при увеличении числа языков заменим на case

        {
            if (WeekDayName) return arrWeekDaysRus[wkDaynumber];
            else return arrDaysRus[wkDaynumber];
        }
        else
        {
            if (WeekDayName) return arrWeekDaysEng[wkDaynumber];
            else return arrDaysEng[wkDaynumber];
        }

    }
    //  
    //  Метод построения инвертированного числа (т.е.числа, полученного из исходного
    //                  путем перстановки его цифр в обратном порядке)
    //
    public static int Inverse(int num)
    {
        int newnumber = 0;

        while (num > 0)
        { newnumber = newnumber * 10 + num % 10; num /= 10; }
        return newnumber;
    }





}
