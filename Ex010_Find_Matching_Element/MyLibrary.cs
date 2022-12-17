// Библиотека - долой колхоз!!!
//
public static class MyLibrary
{
//
// Метод поиска максимального числа из трех целых чисел
//
public static int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
}
