using ConsoleExtensio;
using Backend;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int orden = ConsoleExtension.GetInt("Enter order of matrix: ");

    Matrix matrix = new Matrix(orden);

    int[,] dates = matrix.GetMatrix();

     for (int i = 0; i < orden; i++)
    {
        for (int j = 0; j < orden; j++)
        {
            Console.Write($"{dates[i, j]}\t");
        }

        Console.WriteLine();
    }

    
    int summation = matrix.GetSummation();
    int maximum = matrix.GetMaximum();
    int minimum = matrix.GetMinimum();

    Console.WriteLine($"The  summations is: {summation}");
    Console.WriteLine($"The maximum value is: {maximum}");
    Console.WriteLine($"The minimum value is: {minimum}");

    do
    {
        answer = ConsoleExtension.GetValidOptions(
            "Desea continuar? s/n: ",
            options
        );

    } while (!options.Any(x =>
        x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");