using BusinessLogic;
using Models;
using NUnit.Framework;
using DataFluentApi.Entities;
using System.Reflection;


namespace Test
{
    [TestFixture]
    public class TestValidation
    {
        

        [SetUp]
        public void Setup()
        {

        }


        [Test]
        [TestCase("mona@gmail.com")]
        [TestCase("reeth@gmail.com")]
        [TestCase("arjun@gmail.com")]
        [TestCase("Amala._@gmail.com")]
        [TestCase("sowmya")]

        public void TestValidateEmailId(string EmailId)
        {
            var actual = Validation.IsValidEmailId(EmailId);
            Assert.AreEqual( actual,EmailId);
        }


        [Test]
        [TestCase("9876468904")]
        [TestCase("6578904326")]
        [TestCase("6533")]
        [TestCase("013234556")]
        public void TestValidatePhoneNumber(string Contact_Number)
        {
            var actual = Validation.IsContactNumberValid(Contact_Number);
            Assert.AreEqual( actual, Contact_Number);
        }

        [Test]
        [TestCase("male")]
        [TestCase("female")]
        [TestCase("Not prefer to say")]
        [TestCase("Female")]
        [TestCase("Male")]
        [TestCase("femalemale")]
        public void TestValidateGender(string Gender)
        {
            var actual = Validation.IsGenderValid(Gender);
            Assert.AreEqual( actual, Gender);
        }

        [Test]
        [TestCase("Mounika@123")]
        [TestCase("mona")]
        [TestCase("Mahathi@143")]
        [TestCase("Yashu@12")]
        [TestCase("palLavi@98")]
        public void TestValidatePassword(string Password)
        {
            var actual = Validation.IsValidPassword(Password);
            Assert.AreEqual( actual, Password);
        }



        [Test]
        [TestCase("https://www.linkedin.com")]
        [TestCase("http://www.google.org")]
        [TestCase("https://www.twitter.com")]
        [TestCase("https://www.geeksforgeeks.org")]
        [TestCase("https:// youtube")]
       
        public void TestValidateSProfile(string SProfile)
        {
            var actual=Validation.IsValidSProfile(SProfile);
            Assert.AreEqual( actual, SProfile);
           
        }
    }
}