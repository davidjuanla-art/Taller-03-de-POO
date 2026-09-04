namespace ConsoleExtensio;

public class ConsoleExtension
{
    public static int GetInt(string message)
    {
        int numberInt;

        do
        {
            Console.Write(message);
            var numberString = Console.ReadLine();

            if (int.TryParse(numberString, out numberInt) && numberInt > 0)
            {
                return numberInt;
            }

            Console.WriteLine("Ingrese un número entero mayor que 0.");

        } while (true);
    }


    public static string? GetValidOptions(string message, List<string> options)
    {
        string? answer;

        do
        {
            Console.Write(message);
            answer = Console.ReadLine();

            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;
            }

            Console.WriteLine("Opción no válida.");

        } while (true);
    }
}
