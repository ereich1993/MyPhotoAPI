using gRATE.Models;
using NUnit.Framework;

namespace gRate.Test
{
    [TestFixture]
    internal class UserTests
    {
        [Test]
        public void SanityCheck()
        {
            Assert.NotNull(new User());
        }

        [Test]
        public void TestCtor_argsPassed_valuesSet()
        {
            object[] expectedValues = new object[]
            {
                1,
                "TestName",
                3,
                "Test@email.com"
            };

            User user = new User()
            {
                Id = (int)expectedValues[0],
                Name = (string)expectedValues[1],
                CreditCount = (int)expectedValues[2],
                Email = (string)expectedValues[3]
            };

            object[] actualValues = new object[]
            {
                user.Id,
                user.Name,
                user.CreditCount,
                user.Email
            };

            Assert.AreEqual(expectedValues, actualValues);
        }
    }
}