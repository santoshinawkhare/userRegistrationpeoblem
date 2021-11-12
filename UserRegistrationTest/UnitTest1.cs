using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {
        PatternCheck check;

        [SetUp]
        public void Setup()
        {
            check = new PatternCheck();
        }
        [Test]
        public void FNameTest()
        {
            var result = check.FirstNameValidation("Santoshi");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void LnameTest()
        {
            var result = check.LastNameValidation("Nawkhare");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void PhoneTest()
        {
            var result = check.PhoneNoValidation("91 7447880945");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void EmailTest()
        {
            var result = check.EmailValidation("santoshinawkhare@gmail.com");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void PasswordTest()
        {
            var result = check.ValidatePassword("Santoshi-123");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void PasswordTest6()
        {
            var result = check.ValidatePassword6("Santoshi-123");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void PasswordTest7()
        {
            var result = check.ValidatePassword7("Santi@12");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void PasswordTest8()
        {
            var result = check.ValidatePassword8("Santi@12");
            Assert.AreEqual(true, result);
        }
        [Test]
        public void UC9()
        {
            var result = check.UC9("");
            Assert.AreEqual(true, result);
        }
    }
}