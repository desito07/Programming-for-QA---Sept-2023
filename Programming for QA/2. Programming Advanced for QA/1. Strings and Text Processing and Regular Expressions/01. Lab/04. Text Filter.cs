﻿
string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    //string censorWord = "".PadLeft(bannedWords.Length, '*');
    string censorWord = new string('*', bannedWord.Length);

    while (text.Contains(bannedWord))
    {
        text = text.Replace(bannedWord, censorWord);
    }
}
Console.WriteLine(text);