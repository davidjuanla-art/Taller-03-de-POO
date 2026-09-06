using ConsoleExtensio;
using Factorization.Backend;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int number = ConsoleExtension.GetInt("Enter the number to descompose: ");

    Factor factor = new Factor(number);

    List<int> factors = factor.Factoritation();

    Console.Write($"{number} = ");

    for (int i = 0; i < factors.Count; i++)
    {
        Console.Write(factors[i]);

        if (i < factors.Count - 1)
        {
            Console.Write(" x ");
        }
    }

    Console.WriteLine();

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