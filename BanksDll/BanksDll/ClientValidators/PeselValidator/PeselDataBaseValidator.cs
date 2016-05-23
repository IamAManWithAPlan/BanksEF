using System.Linq;

namespace BanksDll.ClientValidators.PeselValidator
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