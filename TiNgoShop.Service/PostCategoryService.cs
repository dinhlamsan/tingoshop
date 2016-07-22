using System.Collections.Generic;
using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Data.Repositories;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        PostCategory Delete(int Id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentId(int ParentId);

        PostCategory GetById(int Id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public PostCategory Delete(int Id)
        {
            return _postCategoryRepository.Delete(Id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int ParentId)
        {
            return _postCategoryRepository.GetMulti(s => s.Status && s.ParentId == ParentId);
        }

        public PostCategory GetById(int Id)
        {
            return _postCategoryRepository.GetSingleById(Id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}