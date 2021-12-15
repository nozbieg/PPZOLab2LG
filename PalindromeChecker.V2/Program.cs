using PalindromeChecker.V2;

Console.WriteLine("Program znajdujący najdłuższy palindrom w podanym zdaniu");
Console.WriteLine("Wprowadź zdanie:");

var input = Console.ReadLine();
var palindromeChecker = new PalindromeCheckerProcessor();
var longestPalindrome = palindromeChecker.FindLongestPalindromeInSentence(input);

if (longestPalindrome != null)
{
    Console.WriteLine($"Najdłuższym palindromem w zdaniu:");
    Console.WriteLine($"{input}");
    Console.WriteLine($"jest \"{longestPalindrome}\"");
}
else
{
    Console.WriteLine("W zdaniu: ");
    Console.WriteLine($"{input}");
    Console.WriteLine("nie ma palindromów");
}
