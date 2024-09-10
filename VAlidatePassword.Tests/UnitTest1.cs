using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordValidator;
using System;

namespace VAlidatePassword.Tests
{
    [TestClass]
    public class ValdTests
    {
        [TestMethod]
        public void ValidatePassword_validate1234567890_1return()
        {
            string password = "1234567890";
            int expected = 1;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void ValidatePassword_validate12345678900andfourspecialsimbols_3return()
        {
            string password = "12345678900`!!!%";
            int expected = 3;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePassword_validateempty_0return()
        {
            string password = " ";
            int expected = 0;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePassword_validate123456ga_2return()
        {
            string password = "123456ga";
            int expected = 2;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePassword_validate12345678900andfourspecialsimbolsaa_3return()
        {
            string password = "12345678900`!!!%aa";
            int expected = 4;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePassword_validate12345678900andfourspecialsimbolsaAaAD_5return()
        {
            string password = "12345678900`!!!%aAaAD";
            int expected = 5;
            Vald vald = new Vald();
            int actual = vald.ValidatePassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}
