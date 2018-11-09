using gRATE.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace gRate.Test
{
    [TestFixture]
    class ImageTests
    {

        [Test]
        public void SanityCheck()
        {
            Assert.NotNull(new Image());
        }

        [Test]
        public void TestCtor_argsPassed_valuesSet()
        {
            object[] expectedValues =new object[]
            {
                1,
                "samplePath",
                Category.Animal,
                DesiredVoteCount.S,
                new User(),
                "SampleTitle",
                "sampleDesc",
                new DateTime(2011,12,11,10,9,8)
            };

            Image image = new Image()
            {
                Id = (int)expectedValues[0],
                Path = (string)expectedValues[1],
                Category = (Category)expectedValues[2],
                DesiredVoteCount = (DesiredVoteCount)expectedValues[3],
                Owner = (User)expectedValues[4],
                Title = (string)expectedValues[5],
                Description = (string)expectedValues[6],
                UploadedOn = (DateTime)expectedValues[7]
            };

            object[] actualValues = new object[]
            {
                image.Id,
                image.Path, 
                image.Category,
                image.DesiredVoteCount,
                image.Owner,
                image.Title,
                image.Description,
                image.UploadedOn
            };

            Assert.AreEqual(expectedValues, actualValues);
        }
    }
}
