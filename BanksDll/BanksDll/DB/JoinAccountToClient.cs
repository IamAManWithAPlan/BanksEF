using System.Linq;
using BanksDll.AccountFiles;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.DB
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
                    FKBankID = GetBankId(model.BankName)
                });
                context.SaveChanges();
            }
        }

        private int GetBankId(string bankName)
        {
            using (var context = new BanksEntities())
            {
                return (context.Bank.Where(x => x.BankName.Equals(bankName)).
                    Select(x => x.BankID)).ToList().First();
            }
        }
    }
}