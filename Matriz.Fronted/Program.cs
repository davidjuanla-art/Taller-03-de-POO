using ConsoleExtensio;
using Backend;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int orden = ConsoleExtension.GetInt("Enter order of the matrix: ");

    Matrix matrix = new Matrix(orden);


    int[,] datos = matrix.GetMatrix();

    
    for (int i = 0; i < orden; i++)
    {
        for (int j = 0; j < orden; j++)
        {
            Console.Write($"{datos[i, j]}\t");
        }

        Console.WriteLine();
       
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions( "Desea continuar? s/n: ", options );

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("game over");

int summation = matrix.GetSummation();

Console.WriteLine($"Sumatoria: {summation}");