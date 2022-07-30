// метод возвращает строку из элементов строкого массива array
string ShowStringArray(string[] array)
{
    string strArray = String.Empty;
    int length = array.Length;
    for(int i = 0; i < length; i++)
        strArray += array[i] +  (( i < length - 1 )?", ":"");

    return strArray;
}

// метод возвращает количество строк в массиве array, длина которых меньше или равна max
int CountShortWords(string[] array, int max)
{
    int count = 0;
    if (max > 0)
        for(int i = 0; i < array.Length; i++)
            if(array[i].Length <= max) count++;

    return count;
}

// метод возвращет массив строк, состоящий из строк массива sourceArray длина которых меньше или равна lenWords
string[] NewArrayShortWords(string[] sourceArray, int lenWords)
{

    int count = CountShortWords(sourceArray, lenWords);
    string[] newArray = new string[count];
    int i =0;   
    int j =0;
    int size = sourceArray.Length;

    while(i < size)
    {
        if(sourceArray[i].Length <= lenWords)
        {
            newArray[j] = sourceArray[i];
            j++;
        }
        i = i + 1;
    }
    return newArray;
}

//=============================================================================================
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Пример: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
//---------------------------------------------------------------------------------------------


string[] arrayString = { "one", "two", "three", "four", "five","six", "seven", "eight","end","+1",":23"};
int stringLength = 3;

string[] newarray = NewArrayShortWords( arrayString, stringLength );
Console.WriteLine($"array of strings whose length is less than or equal to {stringLength} characters: " + ShowStringArray( newarray ) );


