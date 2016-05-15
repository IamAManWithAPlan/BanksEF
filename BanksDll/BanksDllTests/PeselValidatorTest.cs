using BanksDll.ClientValidators.PeselValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BanksDllTests
{
    [TestClass]
    public class PeselValidatorTest
    {
        [TestMethod]
        public void ValidatePeselDate()
        {
            Assert.AreEqual(1994, new PeselDate().GetYearFromPesel("94120807274"));
            Assert.AreEqual(12, new PeselDate().GetMouthFromPesel("94120807274"));
            Assert.AreEqual(8, new PeselDate().GetDayFromPesel("94120807274"));
        }

        [TestMethod]
        public void ValidatePesel()
        {
            IPeselValidator validator = new PeselValidator();
            Assert.IsTrue(validator.Validate("94120807274"));
            Assert.IsFalse(validator.Validate("94120807275"));
        }
    }
}