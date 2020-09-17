using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3Code;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        /*public void LoginWithCorrectCredentialsSuccessful()
        {
            //arrange
            const string username = "AndyStange17";
            const string password = "AS0717@!";

            FakeAppUserRepository FakeUser = new FakeAppUserRepository();
            //act
            

            //assert
            
        }*/
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
