using static MyLibrary;   //  ссылка на библиотеку 
//
//
//               0  1  2 3  4  5  6  7  
int [] array  = {1,12,31,4,15,16,17,18};

int n = array.Length;

int find = 4;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
      Console.WriteLine ($"{"array[4] ="}" + $"{array[index],4}" + ", index = " + $"{index,4}");
      break;
    }
  index++ ;  
}

