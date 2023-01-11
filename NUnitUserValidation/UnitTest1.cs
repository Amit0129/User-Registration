using User_Registration;
namespace NUnitUserValidation
{
    public class Tests
    {
        bool firstName;
        bool lastName;
        bool mobile;
        bool email;
        bool password;
        [SetUp]
        public void Setup()
        {
            RegexValidation regex = new RegexValidation();
            firstName = regex.CheckName("Amit");
            lastName = regex.CheckName("Nayak");
            mobile = regex.CheckMobileNo("91 9090909090");
            email = regex.CheckEmail("amitkumar40@gmail.com");
            password = regex.CheckPassword("A@k287960");
        }

        [Test]
        public void GivenUserDetails_ReturnsValidationResult()
        {
            if (firstName && lastName && mobile && email && password)
                Assert.Pass("Entry SuccessFull");
            else
                Assert.Fail("Entry Failed");
        }
    }
}