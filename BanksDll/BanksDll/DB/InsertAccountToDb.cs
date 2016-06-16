using AutoMapper;
using BanksDll.AccountFiles;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.DB
{
    public class InsertAccountToDb : IDbSave
    {
        public void Save(AccountModel model)
        {
            using (var context = new BanksEntities())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<AccountModel, Account>().
                ForMember(dst => dst.FK_OwnerPesel, opt => opt.MapFrom(src => src.Pesel)));
                context.Account.Add(Mapper.Map<Account>(model));
//                context.Account.Add(new Account()
//                {
//                    AccountNumber = model.AccountNumber,
//                    AccountLogin = model.AccountLogin,
//                    AccountPassword = model.AccountPassword,
//                    FK_OwnerPesel = model.Pesel,
//                    Cash = 0
//                });
                context.SaveChanges();
            }
        }
    }
}