using gRATE.ViewModels;
using NUnit.Framework;
using System.Collections.Generic;

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
        public void TestEmptyCtor_fieldsAreGiven_fieldsAreSaved()
        {
            ImageViewModel model = new ImageViewModel()
            {
                Category = gRATE.Models.Category.Animal,
                Description = "testDesciption",
                DesiredVoteCount = gRATE.Models.DesiredVoteCount.M,
                Path = "testPath",
                Title = "TestingTesting1234"
            };

            List<object> expectedFields = new List<object>()
            {
               gRATE.Models.Category.Animal,
                "testDesciption",
                gRATE.Models.DesiredVoteCount.M,
                "testPath",
                "TestingTesting1234"
            };

            List<object> actualFields = new List<object>()
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