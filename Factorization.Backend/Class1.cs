namespace Factorization.Backend;

    public class Factor
    {
        // field

        private int number;

        //constructor
        public Factor(int number)
        {
            Number = number;
        }

        //properties

        public int Number 
        { 
            get => number;
            set => number = value; }
         

            //methods
          public int Factoritation()
        {
            do
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else if (number % 3 == 0)
                {
                    number = number / 3;
                }
                else if (number % 5 == 0)
                {
                    number = number / 5;
                }
                else if (number % 7 == 0)
                {
                    number = number / 7;
                }
                else if (number % 11 == 0)
                {
                    number = number / 11;
                }
                else
                {
                    break;
                }

            } while (number > 1);

            return number;
        }


    }
