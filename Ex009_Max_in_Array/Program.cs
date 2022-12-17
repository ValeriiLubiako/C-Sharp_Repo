using static MyLibrary;   //  ссылка на библиотеку 
//
//
//                0  1  2  3  4  5  6  7  8 
int[] array = { 11, 21, 31, 41, 15, 61, 71, 18, 19 };
array[0] = 12;
Console.WriteLine(array[4]);

int result = Max(
                Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
            );


Console.WriteLine(result);
