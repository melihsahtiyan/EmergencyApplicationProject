using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }


        public IDataResult<List<Post>> GetAllPosts()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll(), Messages.PostsListed);
        }

        public IDataResult<List<Post>> GetAllByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll(p => p.CategoryId == categoryId),Messages.PostListed);
        }

        public IDataResult<Post> GetById(int id)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p => p.Id == id),Messages.PostListed);
        }

        public IResult Add(Post post)
        {
            post.Date = DateTime.Now;
            _postDal.Add(post);
            return new SuccessResult(Messages.PostAdded);
        }

        public IResult Update(Post post)
        {
            _postDal.Update(post);
            return new SuccessResult(Messages.PostUpdated);
        }

        public IResult Delete(Post post)
        {
            _postDal.Delete(post);
            return new SuccessResult(Messages.PostDeleted);
        }

        public IDataResult<List<PostDetailDto>> GetAllPostDetails()
        {
            return new SuccessDataResult<List<PostDetailDto>>(_postDal.GetAllPostDetails(), Messages.ImagePostsListed);
        }

        public IDataResult<PostDetailDto> GetPostDetailByUserId(int id)
        {
            return new SuccessDataResult<PostDetailDto>(_postDal.GetPostDetailByUserId(id), Messages.VoicePost);
        }

        public IDataResult<Post> GetByUserIdAndLatestDate(int userId)
        {
            return new SuccessDataResult<Post>(
                _postDal.GetAll(p => p.UserId == userId).FindLast(p => p.Date == DateTime.Today));
        }

        public IDataResult<Post> GetByDateLatest()
        {
            return new SuccessDataResult<Post>(_postDal.GetAll().FindLast(p => p.Date == DateTime.Today));
        }
    }
}
