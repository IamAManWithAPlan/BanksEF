using System.Collections.Generic;
using BanksDll.AccountFiles.Interfaces;
using BanksDll.AccountFiles.Validators;

namespace BanksDll.AccountFiles
{
    public static class GenerateAccDetails
    {
        public static void Generate(AccountModel model)
        {
            if (!AccountModelVaildator.Validate(model)) return;
            var generatorsList = new List<IAccountDetailsGenerator>()
            {
                new BankAccountLoginGenerator(),
                new BankAccountNumberGenerator(),
            };
            generatorsList.ForEach(x=> x.Generate(model));
        }
    }
}