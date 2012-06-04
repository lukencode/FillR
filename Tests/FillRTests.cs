using System;
using FillR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Last_Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public DateTime? DOB { get; set; }
    }

    [TestClass]
    public class FillRTests
    {
        [TestMethod]
        public void PersonFiller()
        {
            var person = FillR.FillR.Fill<Person>();

            Assert.IsTrue(!string.IsNullOrWhiteSpace(person.FirstName), "First Name Missing");
            Assert.IsTrue(!string.IsNullOrWhiteSpace(person.Last_Name), "Surname Name Missing");
            Assert.IsTrue(!string.IsNullOrWhiteSpace(person.Username), "Username Name Missing");
            Assert.IsTrue(!string.IsNullOrWhiteSpace(person.Email), "Email Name Missing");
            Assert.IsTrue(!string.IsNullOrWhiteSpace(person.Company), "Company Name Missing");
            Assert.IsTrue(person.DOB.HasValue, "DOB is missing");
        }
    }
}
