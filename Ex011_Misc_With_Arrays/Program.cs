using static MyLibrary;   //  ссылка на библиотеку
//

//               0  1  2 3  4  5  6  7  



int [] array = CreateIntArray (20);

FillArray(array, -10, 10);

array [5] = 20;
int pos20 = IndexOf (array, 20);

PrintArray (array);

Console.WriteLine ();
Console.WriteLine ();

PrintArrayInLine (array,5);

Console.WriteLine ();
Console.WriteLine ();

PrintArrayInLine (array,7);




Console.WriteLine ();
Console.WriteLine ();
Console.WriteLine ("Индекс элемента, равного 20:" + $"{pos20,4}");