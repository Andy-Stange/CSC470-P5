using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3Code;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]

        public void LoginWithCorrectCredentialsSucccess()
        {
            //arrange
            const string UserName = "AndyStange17";
            const string Password = "AS0717@!";
            FakeAppUserRepository RealUser = new FakeAppUserRepository();

            //act

            Boolean Auth = RealUser.Login(UserName, Password);

            //assert
            Assert.IsTrue(Auth);
        }

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
