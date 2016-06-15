using BanksDll.AccountFiles;
using BanksDll.AccountFiles.Interfaces;
using BanksDll.AccountFiles.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BanksDllTests
{
    [TestClass]
    public class PeselValidatorTest
    {
        [TestMethod]
        public void ValidatePeselDate()
        {
            Assert.AreEqual(1959, new PeselDate().GetYearFromPesel("59050316201"));
            Assert.AreEqual(5, new PeselDate().GetMouthFromPesel("59050316201"));
            Assert.AreEqual(3, new PeselDate().GetDayFromPesel("59050316201"));
        }

        [TestMethod]
        public void ValidatePesel()
        {
            IAccountValidator validator = new PeselValidator();
            var model = new AccountModel()
            {
                Name = "Janusz",
                Surname = "Frameworka",
                AccountPassword = "12345678",
                RePassword = "12345678",
                Pesel = "59050316201",
            };
            Assert.IsTrue(validator.Validate(model));
        }
    }
}