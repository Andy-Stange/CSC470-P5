using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3Code;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class LoginFail
    {
        [TestMethod]
        
        public void LoginWithIncorrectCredentialsFail()
        {
            //arrange
            const string UserName = "AaronRodgers12";
            const string Password = "greenandgold";
            FakeAppUserRepository FakeUser = new FakeAppUserRepository();

            //act

            Boolean Auth = FakeUser.Login(UserName, Password);

            //assert
            Assert.IsFalse(Auth);
        }
    }
}
