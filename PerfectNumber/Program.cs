

using PerfectNumber;

Console.WriteLine("Program wyznaczający wszystkie liczby doskonałe z przedziału <a,b>!");
Console.WriteLine("a,b są liczbami całkowitymi spełniającymi warunek 0<=a<b<=50000!");

var a = ReadInput("a");
var b = ReadInput("b");
bool isInputValid = IsInputValid(a, b);

while (!isInputValid)
{
    if (!isInputValid)
    {
        Console.WriteLine("Input is out of range. Try Again");
        a = ReadInput("a");
        b = ReadInput("b");
        isInputValid = IsInputValid(a, b);
    }
}

var perfectNumberFinder = new PerfectNumberFinder();
var perfectNumbersInRange = perfectNumberFinder.FindPerectNumbersInRange(a, b);

Console.WriteLine($"Liczby doskonałe z zakresu <{a},{b}> to:");
Console.WriteLine(string.Join(",", perfectNumbersInRange.ToArray()));


int? ReadInput(string str)
{
    Console.WriteLine($"Insert value for {str}");
    var input = Console.ReadLine();
    int? number = null;
    try
    {
        number = Convert.ToInt32(input);
    }
    catch (Exception)
    {
        throw new Exception("input is not a number");
    }
    return number;
}
bool IsInputValid(int? a, int? b)
{
    if (0 <= a && a < b && b <= 50000)
    {
        return true;
    }

    return false;
}