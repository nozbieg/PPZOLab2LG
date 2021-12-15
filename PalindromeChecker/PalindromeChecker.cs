

namespace PalindromeChecker;

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
}

