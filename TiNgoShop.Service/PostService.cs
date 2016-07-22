using System.Collections.Generic;
using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Data.Repositories;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(Post post);

        void Delete(int Id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategory(int categoryId, int page, int pageSize, out int totalRow);

        Post GetById(int Id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        //Khởi tạo service & tiêm 2 đối tượng postRepository, unitOfWork vào service thông qua cơ chế Dependency Injection
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(Post post)
        {
            _postRepository.Delete(post);
        }

        public void Delete(int Id)
        {
            _postRepository.Delete(Id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByCategory(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(s => s.Status & s.CategoryId == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        //TODO: Select all post by tag
        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(s => s.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int Id)
        {
            return _postRepository.GetSingleById(Id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}