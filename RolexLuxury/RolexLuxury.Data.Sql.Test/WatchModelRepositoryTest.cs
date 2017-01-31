using Moq;
using NUnit.Framework;
using RolexLuxury.Common.Helper;
using RolexLuxury.Data.Sql;
using RolexLuxury.Data.Sql.Repository;
using RolexLuxury.Models.Watch;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RolexLuxury.Data.Sql.Test
{
    [TestFixture]
    public class WatchModelRepositoryTest
    {
        private Mock<RolexLuxuryDBContext> _context;
        private Mock<DbSet<WatchModel>> _dbSetWatchModel;
        private List<WatchModel> _watchModels;
        private IQueryable<WatchModel> _iQWatchModels;
        private WatchModelRepository _repo;

        [SetUp]
        public void Init()
        {
            _context = new Mock<RolexLuxuryDBContext>();

            _watchModels = new List<WatchModel>()
            {
                new WatchModel()
                {
                    Category = "Gold",
                    CreatedBy = "TEST 1",
                    DateCreated = DateTime.Now,
                    Description = "ROLEX GOLD",
                    WatchModelId = 1,
                    DateModified = null,
                    ModifiedBy = null
                },
                new WatchModel()
                {
                    Category = "Gold",
                    CreatedBy = "TEST 1",
                    DateCreated = DateTime.Now,
                    Description = "ROLEX GOLD MASTER",
                    WatchModelId = 2,
                    DateModified = null,
                    ModifiedBy = null
                },
                new WatchModel()
                {
                    Category = "Silver",
                    CreatedBy = "TEST 1",
                    DateCreated = DateTime.Now,
                    Description = "ROLEX SILVER",
                    WatchModelId = 3,
                    DateModified = null,
                    ModifiedBy = null
                },
                new WatchModel()
                {
                    Category = "Silver",
                    CreatedBy = "TEST 1",
                    DateCreated = DateTime.Now,
                    Description = "ROLEX SILVER MASTER",
                    WatchModelId = 4,
                    DateModified = null,
                    ModifiedBy = null
                }
            };

            _iQWatchModels = _watchModels.AsQueryable();

            _dbSetWatchModel = new Mock<DbSet<WatchModel>>();

            _dbSetWatchModel = MockHelper.MockDbSet(_watchModels);

            _context.Setup(s => s.WatchModels).Returns(_dbSetWatchModel.Object);

            _repo = new WatchModelRepository(_context.Object);
        }

        [Test]
        public void WatchModelRepository_Get()
        {
            //Arrange

            //Act
            var result = _repo.Get();

            //Assert
            Assert.IsTrue(result.Result.Count == _watchModels.Count);
        }
    }
}
