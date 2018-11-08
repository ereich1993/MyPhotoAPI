using gRATE.ViewModels;
using NUnit.Framework;
using gRATE.Models;

namespace gRate.Test
{
    [TestFixture]
    internal class ImageViewModelTests
    {
        [Test]
        public void SanityCheck()
        {
            Assert.NotNull(new ImageViewModel());
        }

        [Test]
        public void TestCtor_argsPassed_valuesSet()
        {
            object[] expectedFields = new object[]
            {
               Category.Animal,
                "testDesciption",
                DesiredVoteCount.M,
                "testPath",
                "TestingTesting1234"
            };

            ImageViewModel model = new ImageViewModel()
            {
                Category = (Category)expectedFields[0],
                Description = (string)expectedFields[1],
                DesiredVoteCount = (DesiredVoteCount)expectedFields[2],
                Path = (string)expectedFields[3],
                Title = (string)expectedFields[4]
            };

            object[] actualFields = new object[]
            {
                model.Category,
                model.Description,
                model.DesiredVoteCount,
                model.Path,
                model.Title
            };

            Assert.AreEqual(expectedFields, actualFields);
        }
    }
}