using System.Linq;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles
{
    public class JoinAccountToClient : IDbSave
    {
        public void Save(AccountModel model)
        {
            using (var context = new BanksEntities())
            {
                context.Accounts.Add(new Accounts()
                {
                    FKAccount_Number = model.AccountNumber,
                    FKClientPesel = model.Pesel,
                    FKBankID = getBankId(model.BankName)
                });
                context.SaveChanges();
            }
        }

        private int getBankId(string bankName)
        {
            using (var context = new BanksEntities())
            {
                return (context.Bank.Where(x => x.BankName.Equals(bankName)).
                    Select(x => x.BankID)).ToList().First();
            }
        }
    }
}