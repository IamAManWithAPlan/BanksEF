using System.Linq;
using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators.Validators
{
    public class PeselDataBaseValidator : IPeselValidator
    {
        public bool Validate(string pesel)
        {
            using (var context = new BanksEntities())
            {
                return (from b in context.Client where b.Pesel.Equals(pesel) select b).ToList().Count == 0;
            }
        }
    }
}