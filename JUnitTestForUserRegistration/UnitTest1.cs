using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationDay24;

namespace JUnitTestForUserRegistration
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void ValidateFirstName()
        {
            string firstName = "Arun";
            Patterns patterns = new Patterns();
            bool result = patterns.IsValidFirstName(firstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateLastName()
        {
           string lastName = "Hosur";
           Patterns patterns = new Patterns();
           bool result = patterns.IsValidLastName(lastName);
           Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateEmailId()
        {
            string emailid = "Arunhosur93@gmail.com";
            Patterns patterns = new Patterns();
            bool result = patterns.IsValidEmailId(emailid);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePassword()
        {
             string password = "Arunsh@123";
             Patterns patterns = new Patterns();
             bool result = patterns.IsValidPassword(password);
             Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePhoneNumber()
        {
             string phoneNumber = "91 9620692457";
             Patterns patterns = new Patterns();
             bool result = patterns.IsValidPhoneNumber(phoneNumber);
             Assert.IsTrue(result);
        }
      
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateSampleEmailId(string sampleEmail)
        {
            Patterns patterns = new Patterns();
            Assert.IsTrue(patterns.IsValidSampleEmiailId(sampleEmail));
        }
    }
}
