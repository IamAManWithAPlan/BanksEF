using System.Collections.Generic;
using System.Linq;

namespace BanksDll.ClientValidators.PeselValidator
{
    public class PeselValidator : IPeselValidator
    {
        public bool Validate(string pesel)
        {
            var validators = new LinkedList<IPeselValidator>();
            validators.AddFirst(new PeselNumbersValidator());
            validators.AddFirst(new PeselDateValidator());
            return validators.All(validator => validator.Validate(pesel));
        }
    }
}