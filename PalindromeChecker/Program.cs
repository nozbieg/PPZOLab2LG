
using PalindromeChecker;

Console.WriteLine("Program sprawdzający czy podane słowo jest palindromem");
Console.WriteLine("Wprowadź słowo");

var input = Console.ReadLine();
var palindromeChecker = new PalindromeCheckerProcessor();
var isInputPalindrome = palindromeChecker.IsPalindrome(input);
if (isInputPalindrome)
{
    Console.Write($"Słowo {input} jest palindromem!");
}
else
{
    Console.Write($"Słowo {input} nie jest palindromem!");
}