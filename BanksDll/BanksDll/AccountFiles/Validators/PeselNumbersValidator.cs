using System;
using System.Linq;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class PeselNumbersValidator : IAccountValidator
    {
        //Cyfra kontrolna i sprawdzanie poprawności numeru
        public bool Validate(AccountModel model)
        {
            int[] peselControlNumbers = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            var peselInt = Array.ConvertAll(model.Pesel.ToCharArray(), c => (int) char.GetNumericValue(c));
            var peselTest = peselControlNumbers.Select((t, i) => t*peselInt[i]).Sum();
            peselTest = peselTest%10; 
            if (peselTest == 10) return (peselInt[10] == 0);
            return (peselInt[10] == 10 - peselTest);
        }
    }
}