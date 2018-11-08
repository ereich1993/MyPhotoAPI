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
        public void TestEmptyCtor_fieldsAreGiven_fieldsAreSaved()
        {
            VoteViewModel model = new VoteViewModel()
            {
                ImageId = 1,
                UserId = 2,
                VoteValue = 2
            };

            List<object> expectedFields = new List<object>()
            {
                1,2,2
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
