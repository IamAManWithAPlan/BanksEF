namespace BanksDll.ClientValidators
{
    public interface IAccountValidator
    {
        bool Validate(AccountModel model);
    }
}