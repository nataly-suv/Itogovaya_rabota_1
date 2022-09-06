/* ===============================================================
Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше, либо равна 3 символам
"hello", "2", "word", ":-)"
"1234", "1567", "-2", "computer science"
"Russia", "Denmark", "Kazan"
================================================================*/

// исходная строка 
string[] inputStringArray = { "hello", "2", "word", ":-)" };

// метод подсчета строк с длинной <= 3
int CountElement(string[] inString)
{
    int count = 0;
    for (int i = 0; i < inString.Length; i++)
    {
        if (inString[i].Length <= 3)
            count++;
    }
    return count;
}

// метод создания массива строк с длинной строки <=3
string[] ChangeStringArray(string[] inStringArray, int count)
{
    string[] outStringArray = new string[count];
    int j = 0;
    for (int i = 0; i < inStringArray.Length; i++)
    {
        if (inStringArray[i].Length <= 3)
        {
            outStringArray[j] = inStringArray[i];
            j++;
        }
    }
    return outStringArray;
}

// метод печати  массива 
void PrintArray(string[] inStringArray, int count)
{
    if (count == 0) Console.WriteLine("[]");
    else if (count != 0)
    {
        Console.Write("[");
        for (int i = 0; i < inStringArray.Length - 1; i++)
        {
            Console.Write($"{inStringArray[i]}, ");
        }
        Console.Write($"{inStringArray[inStringArray.Length - 1]}");
        Console.Write("]");
    }

}

//Console.WriteLine(CountElement(inputStringArray));
int count = CountElement(inputStringArray);
string[] newStringArray = ChangeStringArray(inputStringArray, count);
PrintArray(newStringArray, count);
