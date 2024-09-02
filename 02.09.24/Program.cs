// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.UTF8;

//Task 1
/*string inputText()
{
    Console.WriteLine("Input text: ");
    return Console.ReadLine();
}

string inputString = inputText();
Console.WriteLine($"Your text: {inputString}");

string reverseText(string text)
{
    string reversedText = ""; 
    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversedText += text[i]; 
    }
    return reversedText; 
}

string reversedString = reverseText(inputString); 
Console.WriteLine($"Reversed text: {reversedString}");*/

//Task 2
Console.Write("Введіть рядок: ");
string userInput = Console.ReadLine();

string firstLetterChange(string userInput)
{
    if (string.IsNullOrEmpty(userInput))
    {
        return userInput;
    }

    return char.ToUpper(userInput[0]) + userInput.Substring(1);
}

string finalText = firstLetterChange(userInput);
Console.Write($"Результат: {finalText}");
Console.Write(" ");
