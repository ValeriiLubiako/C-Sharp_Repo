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
    // Метод заполнения одномерного целочисленного массива произвольными числами в 
    // залданном диапазоне значений 
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
}

