using gRATE.Data;
using gRATE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace gRate.Test
{
    [TestClass]
    public class UnitTest1
    {
        private DbContextOptions<GRateDbContext> options;

        [TestInitialize]
        public void Initialize()
        {
            options = new DbContextOptionsBuilder<GRateDbContext>()
                .UseInMemoryDatabase(databaseName: "testdb")
                .Options;
        }

        [TestMethod]
        public void TestMethod1()
        {
            using (var ctx = new GRateDbContext(options))
            {
                IRepository repo = new Repository(ctx);

                repo.Add(new User() { Name = "Gyertya" });
                repo.SaveAll();
            }

            using (var ctx = new GRateDbContext(options))
            {
                var cnt = ctx.Users.Count();
                Assert.AreEqual(1, cnt);
            }
        }
    }
}