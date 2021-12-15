
namespace PerfectNumber;

public class PerfectNumberFinder
{
    public List<int?> FindPerectNumbersInRange(int? a, int? b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException(nameof(a));
        }

        var perfectNumberList = new List<int?>();

        for (var currentNumber = a; currentNumber <= b; currentNumber++)
        {
            var isPerfectNumber = IsPerfectNumber(currentNumber);
            if (isPerfectNumber)
            {
                perfectNumberList.Add(currentNumber);
            }
        }


        return perfectNumberList;
    }

    bool IsPerfectNumber(int? currentNumber)
    {
        var sum = 0;
        for (int i = 1; i < currentNumber; i++)
        {
            if (currentNumber % i == 0)
            {
                sum += i;
            }
        }
        if (sum == currentNumber)
        {
            return true;
        }

        return false;
    }
}

