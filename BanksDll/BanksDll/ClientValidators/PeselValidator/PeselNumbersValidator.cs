using System;
using System.Linq;

namespace BanksDll.ClientValidators.PeselValidator
{
    public class PeselNumbersValidator : IPeselValidator
    {
        //Cyfra kontrolna i sprawdzanie poprawności numeru
        public bool Validate(string pesel)
        {
            int[] peselControlNumbers = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            var peselInt = Array.ConvertAll(pesel.ToCharArray(), c => (int) char.GetNumericValue(c));
            var peselTest = peselControlNumbers.Select((t, i) => t*peselInt[i]).Sum();
            peselTest = peselTest%10;
            if (peselTest == 10) return (peselInt[10] == 0);
            return (peselInt[10] == 10 - peselTest);
        }
    }
}