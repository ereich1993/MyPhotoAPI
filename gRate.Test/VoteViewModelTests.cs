using gRATE.ViewModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace gRate.Test
{
    [TestFixture]
    class VoteViewModelTests
    {
        [Test]
        public void SanityCheck()
        {
            Assert.NotNull(new VoteViewModel());
        }

        [Test]
        public void TestCtor_argsPassed_valuesSet()
        {
            object[] expectedFields = new object[]
            {
                1,2,2
            };

            VoteViewModel model = new VoteViewModel()
            {
                ImageId = (int)expectedFields[0],
                UserId = (int)expectedFields[1],
                VoteValue = (int)expectedFields[2]
            };

            List<object> actualFields = new List<object>()
            {
                model.ImageId,
                model.UserId,
                model.VoteValue
            };

            Assert.AreEqual(expectedFields, actualFields);

        }
    }
}
