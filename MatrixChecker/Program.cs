
using MatrixChecker;

Console.WriteLine("Program sprawdzający czy macierz A o wymiarach n* jest osobliwa");
Console.WriteLine("Danymi wejściowymi są liczby całkowite.");
Console.WriteLine("W zadaniu nie jest sprecyzowany sposób wprowadzania macierzy. Zostanie ona wygenerowana na podstawie wprowadzonej wielkości w zakresie 0<7.");

Console.WriteLine("Wprowadź rozmiar macierzy");

var matrixSize = ReadInput("Matrix size");

if (!IsInputValid(matrixSize))
{
    Console.WriteLine("Rozmiar macierzy nie jest spoza zakresy");
}

var matrixProcessor = new MatrixProcessor();
var matrix = matrixProcessor.GenerateMatrix(matrixSize);
//int[,] matrix = new int[3, 3];  //Test 3x3 values
//matrix[0, 0] = 1;
//matrix[0, 1] = 2;
//matrix[0, 2] = 0;
//matrix[1, 0] = -4;
//matrix[1, 1] = 1;
//matrix[1, 2] = 0;
//matrix[2, 0] = -1;
//matrix[2, 1] = 8;
//matrix[2, 2] = 0;

var determinant = matrixProcessor.ComputeDeterminant(matrix, matrixSize);

if (determinant == 0)
{
    Console.WriteLine("Macierz :");
    matrixProcessor.PrintMatrix(matrix, matrixSize);
    Console.WriteLine($"Posiada wyznacznik o wartości: {determinant}");
    Console.WriteLine($"Ta macierz jest osobliwa");
}
else
{
    Console.WriteLine("Macierz :");
    matrixProcessor.PrintMatrix(matrix, matrixSize);
    Console.WriteLine($"Posiada wyznacznik o wartości: {determinant}");
    Console.WriteLine($"Ta macierz nie jest osobliwa");
}


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
bool IsInputValid(int? input)
{
    if (0 <= input && input < 7)
    {
        return true;
    }

    return false;
}