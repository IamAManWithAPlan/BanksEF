using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class PeselDateValidator : IPeselValidator
    {
        public bool Validate(string pesel)
        {
            var peselDate = new PeselDate();

            if (peselDate.GetMouthFromPesel(pesel) > 12 || peselDate.GetMouthFromPesel(pesel) <= 0) return false;
            int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (IsLeap(peselDate.GetYearFromPesel(pesel))) daysInMonth[1] = 29;
            return peselDate.GetDayFromPesel(pesel) <= daysInMonth[peselDate.GetMouthFromPesel(pesel) - 1];
        }


        private static bool IsLeap(int year)
        {
            return (year%4 == 0 && year%100 != 0 || year%400 == 0);
        }
    }
}