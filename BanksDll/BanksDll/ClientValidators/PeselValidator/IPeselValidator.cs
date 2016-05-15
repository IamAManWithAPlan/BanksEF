namespace BanksDll.ClientValidators.PeselValidator
{
    public interface IPeselValidator
    {
        bool Validate(string pesel);
    }
}