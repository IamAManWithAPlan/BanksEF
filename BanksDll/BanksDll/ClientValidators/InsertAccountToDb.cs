using AutoMapper;
using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators
{
    public class InsertAccountToDb : IDbSave
    {
        public void Save(AccountModel model)
        {
            using (var context = new BanksEntities())
            {
//                Mapper.Initialize(cfg => cfg.CreateMap<AccountModel, Account>().
//                ForMember(dst => dst.FK_OwnerPesel, opt => opt.MapFrom(src => src.Pesel)));
//                context.Account.Add(Mapper.Map<Account>(model));
                context.Account.Add(new Account()
                {
                    AccountNumber = model.Number,
                    AccountLogin = model.Login,
                    AccountPassword = model.Password,
                    FK_OwnerPesel = model.Pesel,
                    Cash = 0
                });
                context.SaveChanges();
            }
        }
    }
}