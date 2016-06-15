using AutoMapper;
using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators
{
    public class InsertClientToDb : IDbSave
    {
        public void Save(AccountModel model)
        {
            using (var context = new BanksEntities())
            {
                Mapper.Initialize(cfg => cfg.CreateMap<AccountModel, Client>());
                context.Client.Add(Mapper.Map<Client>(model));
                context.SaveChanges();
            }
        }
    }
}