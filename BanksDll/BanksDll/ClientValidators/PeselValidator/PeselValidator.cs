using System.Collections.Generic;
using System.Linq;

namespace BanksDll.ClientValidators.PeselValidator
{
    public class PeselValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            var validators = new List<IPeselValidator>
            {
                new PeselNumbersValidator(),
                new PeselDateValidator(),
                new PeselDataBaseValidator(),
            };
            return validators.All(validator => validator.Validate(model.Pesel));
        }
    }
}