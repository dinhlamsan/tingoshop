using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Data.Repositories;
using TiNgoShop.Model.Models;

namespace TiNgoShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "TestAlias";
            category.Status = true;

            var result =objRepository.Add(category);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Id);
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(10, list.Count);
        }
    }
}