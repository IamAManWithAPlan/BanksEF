using System.Linq;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles
{
    public class BankAccountNumberGenerator : IAccountDetailsGenerator
    {
        public void Generate(AccountModel model)
        {
            model.AccountNumber = GetCrucialNumber(model.BankName)+model.Pesel;
        }

        private static string GetCrucialNumber(string bankName)
        {
            using (var context = new BanksEntities())
            {
                return (context.Bank.Where(x => x.BankName.Equals(bankName)).Select(x => x.BankCrucialNumbers)).ToList().First();
            }
        }
    }
}