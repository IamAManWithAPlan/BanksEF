namespace BanksDll.ClientValidators.Interfaces
{
    public interface IAccountValidator
    {
        bool Validate(AccountModel model);
    }
}