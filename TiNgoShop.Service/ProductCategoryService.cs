using System.Collections.Generic;
using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Data.Repositories;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        void Delete(ProductCategory productCategory);

        void Delete(int Id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow);

        ProductCategory GetById(int Id);

        IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChange();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategoryRepository.Add(productCategory);
        }

        public void Delete(ProductCategory productCategory)
        {
            _productCategoryRepository.Delete(productCategory);
        }

        public void Delete(int Id)
        {
            _productCategoryRepository.Delete(Id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll(new string[] { "Product" });
        }

        public IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _productCategoryRepository.GetMultiPaging(s => s.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productCategoryRepository.GetMultiPaging(s => s.Status, out totalRow, page, pageSize);
        }

        public ProductCategory GetById(int Id)
        {
            return _productCategoryRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }
    }
}