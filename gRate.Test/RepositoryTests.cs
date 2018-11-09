using gRATE.Data;
using gRATE.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRate.Test
{
    [TestFixture]
    internal class RepositoryTests
    {
        private DbContextOptions<GRateDbContext> _options;
        private GRateDbContext _context;
        

        [SetUp]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<GRateDbContext>()
                .UseInMemoryDatabase(databaseName: "testdb")
                .Options;
            _context = new GRateDbContext(_options);
            
        }

        [TearDown]
        public void Teardown()
        {
            _options = null;
            _context = null;
        }

        [Test]
        public async Task TestGetAllImagesByUser_UserIdGiven_ImagesReturnedAsync()
        {
            ///Arrange
            Repository repo = new Repository(_context);
            User testUser = new User()
            {
                Id = 1,
                Name = "Pajtás"
            };
            User testUser2 = new User()
            {
                Id = 2,
                Name = "Hajtás"
            };

            repo.Add(testUser);
            repo.Add(testUser2);

            Image[] testImgs = new Image[] {
                new Image()
                {
                    Id = 1,
                    Owner = testUser
                },
                new Image()
                {
                    Id = 2,
                    Owner =testUser2
                },
                new Image()
                {
                    Id = 3,
                    Owner = testUser
                }
            };

            foreach (var img in testImgs)
            {
                repo.Add(img);
            }
            await repo.SaveAll();

            ///Act
            List<Image> cnt = (List<Image>)await repo.GetAllImagesByUserId(testUser.Id);

            ///Assert
            Assert.AreEqual(2, cnt.Count);
        }
    }
}