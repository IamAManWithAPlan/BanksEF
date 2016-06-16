using AutoMapper;
using BanksDll.AccountFiles;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.DB
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