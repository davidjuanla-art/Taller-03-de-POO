using ConsoleExtensio;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    Console.WriteLine("Enter the order of the matrix");

    int order = ConsoleExtension.GetInt("Enter the order of the matrix: ");

    // Aquí ya tenemos un dato validado
    // Podemos conectarlo con nuestra clase Matriz

    Console.WriteLine($"Order of Matrix {order}");

    answer = ConsoleExtension.GetValidOptions(
        "Do you wish to continue? yes/not: ",
        options
    );

} while (answer!.Equals(
    "si",
    StringComparison.CurrentCultureIgnoreCase
));

Console.WriteLine("game over");