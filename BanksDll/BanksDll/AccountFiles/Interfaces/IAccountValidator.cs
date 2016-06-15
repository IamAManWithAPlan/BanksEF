namespace BanksDll.AccountFiles.Interfaces
{
    public interface IAccountValidator
    {
        bool Validate(AccountModel model);
    }
}