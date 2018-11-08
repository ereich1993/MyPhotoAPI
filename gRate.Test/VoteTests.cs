using gRATE.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace gRate.Test
{
    [TestFixture]
    class VoteTests
    {
        [Test]
        public void SanityCheck()
        {
            Assert.NotNull(new Vote());
        }

        [Test]
        public void TestCtor_argsPassed_valuesSet()
        {
            object[] expectedValues = new object[]
            {
                1,
                new Image(),
                new User(),
                new DateTime(2018,12,12,12,12,12)
            };

            Vote vote = new Vote()
            {
                Id = (int)expectedValues[0],
                Image = (Image)expectedValues[1],
                User = (User)expectedValues[2],
                Date = (DateTime)expectedValues[3]
            };

            object[] actualValues = new object[]
            {
                vote.Id,
                vote.Image,
                vote.User,
                vote.Date
            };

            Assert.AreEqual(expectedValues, actualValues);
        }
    }
}
