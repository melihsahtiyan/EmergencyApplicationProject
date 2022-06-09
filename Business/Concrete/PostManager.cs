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

        public IDataResult<List<PostImageDto>> GetAllImagePosts()
        {
            return new SuccessDataResult<List<PostImageDto>>(_postDal.GetAllImagePosts(), Messages.ImagePostsListed);
        }

        public IDataResult<List<PostTextDto>> GetAllTextPosts()
        {
            return new SuccessDataResult<List<PostTextDto>>(_postDal.GetAllTextPosts(), Messages.TextPostsListed);
        }

        public IDataResult<List<PostVideoDto>> GetAllVideosPosts()
        {
            return new SuccessDataResult<List<PostVideoDto>>(_postDal.GetAllVideosPosts(), Messages.VideoPostsListed);
        }

        public IDataResult<List<PostVoiceDto>> GetAllVoicePosts()
        {
            return new SuccessDataResult<List<PostVoiceDto>>(_postDal.GetAllVoicePosts(), Messages.VoicePostsListed);
        }

        public IDataResult<PostImageDto> GetImagePostByUserId(int id)
        {
            return new SuccessDataResult<PostImageDto>(_postDal.GetImagePostByUserId(id), Messages.ImagePost);
        }

        public IDataResult<PostTextDto> GetTextPostByUserId(int id)
        {
            return new SuccessDataResult<PostTextDto>(_postDal.GetTextPostByUserId(id), Messages.TextPost);
        }

        public IDataResult<PostVideoDto> GetVideosPostByUserId(int id)
        {
            return new SuccessDataResult<PostVideoDto>(_postDal.GetVideosPostByUserId(id), Messages.VideoPost);
        }

        public IDataResult<PostVoiceDto> GetVoicePostByUserId(int id)
        {
            return new SuccessDataResult<PostVoiceDto>(_postDal.GetVoicePostByUserId(id), Messages.VoicePost);
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
