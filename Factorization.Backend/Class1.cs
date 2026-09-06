namespace Factorization.Backend;

public class Factor
{
    // field
    private int number;

    // constructor
    public Factor(int number)
    {
        Number = number;
    }

    // property
    public int Number
    {
        get => number;
        set => number = value;
    }

    // method
    public List<int> Factoritation()
    {
        List<int> factors = new List<int>();

        do
        {
            if (number % 2 == 0)
            {
                factors.Add(2);
                number = number / 2;
            }
            else if (number % 3 == 0)
            {
                factors.Add(3);
                number = number / 3;
            }
            else if (number % 5 == 0)
            {
                factors.Add(5);
                number = number / 5;
            }
            else if (number % 7 == 0)
            {
                factors.Add(7);
                number = number / 7;
            }
            else if (number % 11 == 0)
            {
                factors.Add(11);
                number = number / 11;
            }
            else if (number % 13 == 0)
            {
                factors.Add(13);
                number = number / 13;
            }
            else
            {
                break;
            }

        } while (number > 1);

        return factors;
    }
}
