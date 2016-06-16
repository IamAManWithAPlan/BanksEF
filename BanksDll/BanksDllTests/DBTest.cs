using System;
using System.Collections.Generic;
using BanksDll;
using BanksDll.AccountFiles;
using BanksDll.AccountFiles.Validators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BanksDllTests
{
    [TestClass]
    public class DBTest
    {
        [TestMethod]
        public void TestSaveClient()
        {
            var model = new AccountModel()
            {
                Name = "Majkel",
                Surname = "Aneglo",
                AccountPassword = "12345678",
                RePassword = "12345678",
                Pesel = "59050316201",
                BankName = "ING",
            };

            //            Assert.AreEqual(true,new PeselValidator().Validate(model));
            //            Assert.AreEqual(true,new PasswordValidator().Validate(model));
            //            Assert.AreEqual(true,new NameLengthValidator().Validate(model));
            //            Assert.AreEqual(true,FullModelValidate.Validate(model));
            //           GenerateAccDetails.Generate(model);
            //           InsertClientToDb client = new InsertClientToDb();
            //           InsertAccountToDb acc = new InsertAccountToDb();
            //           JoinAccountToClient accToClient = new JoinAccountToClient();
            //            client.Save(model);
            //            acc.Save(model);
            //            accToClient.Save(model);
            //           Assert.AreEqual("105059050316201",model.AccountNumber);

        }
    }
}