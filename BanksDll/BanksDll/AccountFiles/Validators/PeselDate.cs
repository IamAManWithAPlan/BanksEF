using System;
using System.Collections.Generic;
using System.Linq;

namespace BanksDll.AccountFiles.Validators
{
    public class PeselDate
    {
        private const int PeselYearPosistion = 0;
        private const int PeselMonthPosistion = 2;
        private const int PeselDayPosistion = 4;
        private const int PeselNonDateNumbersPosistion = 6;

        public int GetYearFromPesel(string pesel)
        {
            var year = Convert.ToInt32(pesel.Substring(PeselYearPosistion, PeselMonthPosistion));
            var yearCode = new Dictionary<int, int>
            {
                [80] = 1800,
                [60] = 2200,
                [40] = 2100,
                [20] = 2000,
                [0] = 1900
            };
            var month = Convert.ToInt32(pesel.Substring(PeselMonthPosistion, PeselDayPosistion - PeselMonthPosistion));
            year += (from key in yearCode.Keys where key == month - month%20 select yearCode[key]).FirstOrDefault();
            return year;
        }

        public int GetMouthFromPesel(string pesel)
        {
            var monthNumber =
                Convert.ToInt32(pesel.Substring(PeselMonthPosistion, PeselDayPosistion - PeselMonthPosistion))%20;
            return monthNumber;
        }

        public int GetDayFromPesel(string pesel)
        {
            return Convert.ToInt32(pesel.Substring(PeselDayPosistion, PeselNonDateNumbersPosistion - PeselDayPosistion));
        }
    }
}