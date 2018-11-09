using gRATE.Data;
using gRATE.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace gRate.Test
{
    [TestFixture]
    internal class GRateDbContextTests
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
        public void SanityCheck()
        {
            Assert.NotNull(new GRateDbContext(_options));
        }

        [Test]
        public void TestAddUser_addUser_userCountIncrements()
        {
            IRepository repo = new Repository(_context);
            repo.Add(new User() { Name = "Gyertya" });
            repo.SaveAll();

            var cnt = _context.Users.Count();
            Assert.AreEqual(1, cnt);
        }
    }
}