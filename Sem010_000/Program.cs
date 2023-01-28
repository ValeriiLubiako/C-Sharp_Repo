// Задача 000: Итоговая проверочная работа
// Программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Примеры:
//
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
//
using static MyLibrary;
//
Console.WriteLine(">>>>>------>>>>>" + '\n');
// Console.Write("ВВедите элементы массива через пробел:");
string[] AddArr = {"One","Two", "Three", "Four","Five", "Six"};
// string[] OutArr = new string[AddArr.Length];

// LimitLengthArray(AddArr, OutArr );
PrintStringArray(AddArr);
string[] AddArr2 = {"","Ten","Eleven","","Fourteen"}; 
PrintStringArray( AddArr2);


// Метод построения массива из элементов массива строк, длина которых не превышает 3-х символов
//
//
// void LimitLengthArray(string[] arr1, string[] arr2);
//



