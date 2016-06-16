using System.Linq;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class PeselDataBaseValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            using (var context = new BanksEntities())
            {
                return (from b in context.Client where b.Pesel.Equals(model.Pesel) select b).ToList().Count == 0;
            }
        }
    }
}