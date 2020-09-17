using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3Code;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class LoginPass
    {
        [TestMethod]

        public void LoginWithCorrectCredentialsSucccess()
        {
            //arrange
            const string UserName = "AndyStange17";
            const string Password = "AS0717@!";
            FakeAppUserRepository FakeUser = new FakeAppUserRepository();

            //act

            Boolean Auth = FakeUser.Login(UserName, Password);

            //assert
            Assert.IsTrue(Auth);
        }
    }
}
