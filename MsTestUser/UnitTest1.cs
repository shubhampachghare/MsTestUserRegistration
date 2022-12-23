using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegistration;

namespace MsTestUser
{

    [TestClass]
    public class UnitTest1
    {
        string firstName = "^[A-Z]{1}[a-z]{2,10}$";
        string lastName = "^[A-Z]{1}[a-z]{2,10}$";
        UserDetails us = new UserDetails();
        [TestMethod]
        public void FirstName()
        {
            var result = us.FirstName("Shubham", firstName);
            Assert.AreEqual(true, result.Success);
        }
        //UC2 for last name
        [TestMethod]
        public void LastName()
        {
            var result = us.LastName("Pachghare", lastName);
        Assert.AreEqual(true, result.Success);

        }
}
}