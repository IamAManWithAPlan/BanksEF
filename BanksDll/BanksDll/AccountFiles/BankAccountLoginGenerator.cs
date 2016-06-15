using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles
{
    public class BankAccountLoginGenerator : IAccountDetailsGenerator
    {
        private const int NameLettersToGetLength = 3;
        private const int SurNameLettersToGetLength = 3;
        private const int PeselNumbersToGet= 3;
        public void Generate(AccountModel model)
        {
            model.AccountLogin = model.Name.Substring(0, NameLettersToGetLength) +
                   model.Surname.Substring(0, SurNameLettersToGetLength) +
                   GenerateLoginNumbers(model);
        }

        protected string GenerateLoginNumbers(AccountModel model)
        {
            return model.Pesel.Substring(0, PeselNumbersToGet);
        }
    }
}