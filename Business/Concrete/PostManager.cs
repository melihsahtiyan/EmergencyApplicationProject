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


        public IDataResult<List<Post>> GetAllCategories()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll(), Messages.PostsListed);
        }

        public IDataResult<Post> GetById(int id)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p => p.Id == id),Messages.PostListed);
        }

        public IResult Add(Post post)
        {
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

        public IDataResult<PostImageDto> GetImagePost(int id)
        {
            return new SuccessDataResult<PostImageDto>(_postDal.GetImagePost(id), Messages.ImagePost);
        }

        public IDataResult<PostTextDto> GetTextPost(int id)
        {
            return new SuccessDataResult<PostTextDto>(_postDal.GetTextPost(id), Messages.TextPost);
        }

        public IDataResult<PostVideoDto> GetVideosPost(int id)
        {
            return new SuccessDataResult<PostVideoDto>(_postDal.GetVideosPost(id), Messages.VideoPost);
        }

        public IDataResult<PostVoiceDto> GetVoicePost(int id)
        {
            return new SuccessDataResult<PostVoiceDto>(_postDal.GetVoicePost(id), Messages.VoicePost);
        }
    }
}
