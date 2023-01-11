using User_Registration;
namespace UserRegistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        RegexValidation validation = new RegexValidation();

        [TestMethod]
        [DataRow("Amit", true)]
        [DataRow("Ab", false)]
        [DataRow("amit", false)]
        public void GivenFirstNameValidation(string firstName, bool expected)
        {
            RegexValidation validation = new RegexValidation();
            //Act
            bool actual = validation.CheckName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Kadivar", true)]
        [DataRow("Ab", false)]
        [DataRow("kadivar", false)]
        public void GivenLastNameValidation(string lastName, bool expected)
        {
            //Act
            bool actual = validation.CheckName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("abc123@.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc@1.com", true)]
        public void GivenEmailValidation(string email, bool expected)
        {
            //Act
            bool actual = validation.CheckEmail(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("91 9652545874", true)]
        [DataRow("919652545874", false)]
        [DataRow("9144 9652545874", false)]
        [DataRow("91 1652545874", false)]
        public void GivenMobileNumberValidation(string mobileNumber, bool expected)
        {
            //Act
            bool actual = validation.CheckMobileNo(mobileNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("dA@9fghnjvbn", true)]
        [DataRow("ADFJVGB", false)]
        [DataRow("FVGdf", false)]
        public void GivenPasswordValidation(string password, bool expected)
        {
            //Act
            bool actual = validation.CheckPassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}