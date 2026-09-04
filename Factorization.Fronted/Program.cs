using ConsoleExtensio;
using Factorization.Backend;
using System.Numerics;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    int number = ConsoleExtension.GetInt("Enter a Number: ");

    Factor factor = new Factor(number);

    int result = factor.Factoritation();

    Console.WriteLine($"Result: {result}");

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