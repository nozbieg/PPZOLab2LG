
namespace PalindromeChecker.V2;

public class PalindromeCheckerProcessor
{
    public bool IsPalindrome(string? input)
    {
        if (input == null || string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException("input is invald");
        }
        if (string.Join(string.Empty, input.ToLower().Reverse().ToArray()).Equals(input.ToLower()))
        {
            return true;
        }

        return false;
    }

    public string? FindLongestPalindromeInSentence(string? input)
    {
        if (input == null || string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException("input is invald");
        }
        var splitedInput = input.Split(" ");
        string? longestPalindrome = null;
        foreach (var word in splitedInput)
        {
            if (IsPalindrome(word))
            {
                var longestPalindromeLength = longestPalindrome is null ? 0 : longestPalindrome.Length;
                if (word.Length > longestPalindromeLength) { longestPalindrome = word; }
            }
        }
        return longestPalindrome;
    }
}

