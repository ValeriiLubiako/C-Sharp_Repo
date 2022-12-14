// Библиотека - долой колхоз!!!
//
public static class MyLibrary
{
    private const int V = 12;

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
    // Метод создания одномерного массива с заданным количеством элементов
    // вещественными числами
    // 
    public static double[] CreateRealArray(int count)
    {
        return new double[count];
    }
    //
    // Метод создания двумерного массива с заданным количеством элементов
    // вещественными числами
    //
    public static double[,] CreateRealArrayTwoDim(int rowcount, int colcount)
    {
        return new double[rowcount, colcount];
    }
    //
    //
    // Метод заполнения одномерного целочисленного массива произвольными целыми числами
    // в заданном диапазоне значений 
    //
    public static void FillArray(int[] collection, int argmin, int argmax)
    {
        int length = collection.Length;

        int index = 0;

        while (index < length)
        {
            collection[index] = new Random().Next(argmin, argmax + 1);

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

        while (i < rowcount)
        {
            while (j < colcount)
            {
                collection[i, j] = new Random().Next(argmin, argmax + 1);

                //      collection[index] = Random.Shared.Next(argmin, argmax);

                j++;

            }
            i++;
        }

    }
    //
    // Метод заполнения одномерного массива произвольными вещественными числами
    // в заданном диапазоне значений 
    //
    public static void FillRealArray(double[] collection, int argmin, int argmax)
    {
        int length = collection.Length;

        int index = 0;

        while (index < length)
        {
            ///  collection[index] = new Random().Next(argmin, argmax);

            collection[index] = Convert.ToDouble(new Random().Next(argmin, argmax + 1) / 10.000);

            //      collection[index] = Random.Shared.Next(argmin, argmax);

            index++;

        }
    }
    //
    // Метод заполнения двумерного целочисленного массива произвольными числами в 
    // заданном диапазоне значений 
    //
    public static void FillRealArrayTwoDim(double[,] collection, int argmin, int argmax)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount)
        {
            while (j < colcount)
            {
                collection[i, j] = Convert.ToDouble(new Random().Next(argmin, argmax + 1) / 10.000);

                //      collection[index] = Random.Shared.Next(argmin, argmax);

                j++;

            }
            i++;
        }

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
    //  Метод вывода на печать одномерного массива целых числе в строки по N чисел,
    //  но не больше,чем по 10 чисел в строке
    //
    public static void PrintArrayInLine(int[] arr, int Linelength)
    {
        int Llength = 10;
        Console.WriteLine();

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
    //  Метод вывода на печать одномерного массива вещественных числе в строки по N чисел,
    //  но не больше,чем по 10 чисел в строке
    //
    public static void PrintRealArrayInLine(double[] arr, int Linelength)
    {
        int Llength = 10;
        Console.WriteLine();

        if (Linelength < 10) Llength = Linelength;

        int count = arr.Length;
        int position = 0;
        int k = 1;

        while (position < count)
        {
            if (k < Llength)
            {
                if (position < count - 1) Console.Write($"{arr[position].ToString("F3"),3}" + "; ");
                else Console.Write($"{arr[position].ToString("F3"),3}");
            }
            else
            {
                Console.WriteLine($"{arr[position].ToString("F3"),3}");
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
    //  Метод ввода с терминала строки символов
    //
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
    //  Метод определения количества и суммы цифр в целои числе
    //  на вход подается целое число
    //  возвращается количество цифр в этом числе и их сумма.

    public static int DigitsInNumber(int numberA, out int SumOfDigits)
    {

        int count = 0;

        int n = numberA;

        SumOfDigits = 0;

        if (numberA < 0) n = numberA * (-1);

        while (n > 0)
        {
            count = count + 1;

            SumOfDigits = SumOfDigits + n % 10;

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
    //  
    //  Метод возведения целого числа в степень. Показатель степени - положительное целое число
    //
    public static bool MyPowInt(int A, int B, out int APowB)
    {

        APowB = 0;
        bool flag = false;

        if (B < 0)
        {
            Console.WriteLine("Метод не предназначен для возведения в отрицатеьную степень: " + $"{B,3}");
            return flag;
        }
        else
        {
            if (A == 0 && B == 0) Console.WriteLine("Операция возведения нуля в нулевую степень не определена.");
            else
            {
                if (B == 0) APowB = 1;
                else APowB = A;

                for (int i = 1; i < B; i++) APowB = APowB * A;

                flag = true;

            }
            return flag;

        }

    }
    // Метод вычисления десятичного представления целого числа, заданного в произвольной СС  (по основанию до 16)
    // Метод формирует представлеине числа в заданной СС и вычисляющий его десятичное представление.
    //
    // На вход подается числовой массив, элементами которого задается значение числа в заданной системе счисления,
    // снование системы счисления (до 16).
    // Выходными данными являются строка, содержащая 15-е или 16-е представление числа и
    // десятичное педставление этого числа.
    // использован метод из этой же библиотеки:
    // - MyPowInt() - возвращает значение целого числа возведенного в степень (степень - неотрицатеьное целое число).
    public static bool ConvertNumber(int[] collection, int SystemBase, out string BaseNumber, out int NumberDecimal)
    {

        bool flag = false;  // возвращаемый флажок успешного завершения работы метода (true/false)

        int length = collection.Length;

        int[] DecimalArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        string[] HexArray = { "не определено", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        BaseNumber = String.Empty;

        NumberDecimal = 0;

        if (length > 0)
        {
            int k = 0;

            string line = String.Empty;

            for (int i = 0; i < length; i++)
            {

                int j = MyLibrary.IndexOf(DecimalArray, collection[i]);

                line = line + HexArray[j];

                flag = MyLibrary.MyPowInt(SystemBase, length - 1 - i, out k);
                NumberDecimal = NumberDecimal + collection[i] * k;
                // Console.WriteLine("i=" + $"{i,3}" + "Numberdebug(i)= " + $"{NumberDecimal,3}" + "k= " + $"{k,3}");
                // Console.WriteLine("Line - " + $"{line}");
                flag = true;
                BaseNumber = line;
            }
        }
        else flag = false;    // Метод не отработал т.к. на вход был подан некорректно сфорированный массив 

        return flag;
    }
    public static void HappyNewYear(string[] stringArray)
    //
    //  Метод вывода на консоль поздравления с новым годом
    //  с интервалос в 0ю5 секунды побуквенно формируется строка
    //  С НОВЫМ ГОДОМ!  буквами разных цветов по подобранной гамме
    //  использован метод из этой же библиотеки:
    //  ChangeForegroundColor() - меняет по заданной гамме цвет шрифта на консоли
    //
    {

        // string[] stringArray = new string[25];
        // string[] stringArray = { "С", " ", "Н", "О", "В", "Ы", "М", " ", "Г", "О", "Д", "О", "М", "!", "0" };

        string strout = String.Empty;

        //     for future use
        //         case 0: return stringArray = { "С"," ","Н","О","В","Ы","М"," ","Г","О","Д","О","М","!","0" };
        //         case 1: return stringArray = { "H","A","P","P","Y"," ","N","E","W"," ","Y","E","A","R","!","0" };
        //         case 2: return sringArray = { "Ч","А","С","Т","И","Т","А"," ","Н","О","В","А"," ","Г","О","Д","И","Н","А","!","0"};
        //    

        // int[] ColorsArray = { 12, 10, 9, 11, 13, 14, 0, 15 };
        // ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        int jFColor = 9;

        int k = 0;

        Console.WriteLine(">>>>>>>--------->>>>>>>>---------" + '\n');
        // Console.Clear();
        while (stringArray[k] != "0")
        {


            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = dateTime1;

            // var diffInSeconds = (dateTime1 - dateTime2).TotalSeconds;

            double diffInMilliSeconds = dateTime1.Subtract(dateTime2).TotalMilliseconds;
            while (diffInMilliSeconds < 500)
            {
                dateTime2 = DateTime.Now;
                diffInMilliSeconds = dateTime2.Subtract(dateTime1).TotalMilliseconds;
            }

            strout = strout + stringArray[k];

            // Console.ForegroundColor = ConsoleColor.White;

            //    if (jFColor == 9) jFColor = 14;
            //      if (jFColor == 14) jFColor = 12;
            //       if (jFColor == 12) jFColor = 11;
            //        if (jFColor == 11) jFColor = 10;
            //         if (jFColor == 10) jFColor = 13;
            //          if (jFColor == 13) jFColor = 9;



            // switch (jFColor)    // переключатель цветов в новогоднем поздравлении
            // {
            //     case 9:
            //         jFColor = 14;
            //         break;
            //     case 14:
            //         jFColor = 12;
            //         break;
            //     case 12:
            //         jFColor = 11;
            //         break;
            //     case 11:
            //         jFColor = 10;
            //         break;
            //     case 10:
            //         jFColor = 13;
            //         break;
            //     case 13:
            //         jFColor = 9;
            //         break;
            // }

            jFColor = ChangeForegroundColor(jFColor, strout,k);

            // Console.ForegroundColor = colors[jFColor];

            //Console.Write(strout[k]);
            // DateTime dateTime1 = new DateTime();
            k++;

        }
        Console.ResetColor();
        // Console.Clear();
        Console.WriteLine('\n');
    }
    //
    public static int ChangeForegroundColor(int InitialForegroundColor, string strout, int k)
//
//  Метод меняет по заданной гамме цвет шрифта на консоли в определенной последовательности
//  и выводит на консоль в этом цвете k-й символ строки strout.
//  На вход подаются значения:
//  InitialForegroundColor - номер цвета в классе ConsoleColor;
//  strout - строка, к которой должен быть добавлен символ;
//  k - номер  печатемого сформированным цветом символа (в строке strout);
//  Возвращает новое значение номера цвета в классе ConsoleColor.
    {
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        int jFColor = InitialForegroundColor;

        switch (jFColor)    // переключатель цветов в новогоднем поздравлении
        {
            case 9:
                jFColor = 14;
                break;
            case 14:
                jFColor = 12;
                break;
            case 12:
                jFColor = 11;
                break;
            case 11:
                jFColor = 10;
                break;
            case 10:
                jFColor = 13;
                break;
            case 13:
                jFColor = 9;
                break;
        }
        Console.ForegroundColor = colors[jFColor];
        Console.Write(strout[k]);
        int jFcolorOut = jFColor;
        return jFcolorOut;
    }
}
