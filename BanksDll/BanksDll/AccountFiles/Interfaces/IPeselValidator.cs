namespace BanksDll.AccountFiles.Interfaces
{
    public interface IPeselValidator
    {
        bool Validate(string pesel);
    }
}