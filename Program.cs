﻿string[] ArrayWords = new string[4] {"Hello", "2", "World", ":-)"};
string[] ArrayWords2 = new string [ArrayWords.Length];

void AskWords(string[] ArrayWords, string[] ArrayWords2)
{
    int count = 0;
    for (int i = 0; i < ArrayWords.Length; i++)
    {
        if (ArrayWords[i] <= 3)
        {
            ArrayWords2[count] = ArrayWords[i];
            count++;
        }
    }
}

void PrintArrayWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();

}