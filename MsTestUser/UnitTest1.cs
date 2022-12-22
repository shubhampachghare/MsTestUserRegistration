using MsTestUserRegistration;

namespace MsTestUser
{

    [TestClass]
    public class UnitTest1
    {
        string firstName = "^[A-Z]{1}[a-z]{2,10}$";
        UserDetails us = new UserDetails();
        [TestMethod]
        public void TestMethod1()
        {
            var result = us.FirstName("Shubham", firstName);
            Assert.AreEqual(true, result.Success);
        }
    }
}