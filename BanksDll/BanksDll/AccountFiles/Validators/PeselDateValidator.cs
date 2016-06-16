using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class PeselDateValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            var peselDate = new PeselDate();

            if (peselDate.GetMouthFromPesel(model.Pesel) > 12 || peselDate.GetMouthFromPesel(model.Pesel) <= 0) return false;
            int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (IsLeap(peselDate.GetYearFromPesel(model.Pesel))) daysInMonth[1] = 29;
            return peselDate.GetDayFromPesel(model.Pesel) <= daysInMonth[peselDate.GetMouthFromPesel(model.Pesel) - 1];
        }


        private static bool IsLeap(int year)
        {
            return (year%4 == 0 && year%100 != 0 || year%400 == 0);
        }
    }
}