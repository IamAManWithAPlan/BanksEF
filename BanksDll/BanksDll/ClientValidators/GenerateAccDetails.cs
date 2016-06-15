using System.Collections.Generic;
using BanksDll.ClientValidators.Interfaces;
using BanksDll.ClientValidators.Validators;

namespace BanksDll.ClientValidators
{
    public static class GenerateAccDetails
    {
        public static void Generate(AccountModel model)
        {
            if (!FullModelValidate.Validate(model)) return;
            var generatorsList = new List<IAccountDetailsGenerator>()
            {
                new BankAccountLoginGenerator(),
                new BankAccountNumberGenerator(),
            };
            generatorsList.ForEach(x=> x.Generate(model));
        }
    }
}