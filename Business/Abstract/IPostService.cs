using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IPostService
    {
        IDataResult<List<Post>> GetAllCategories();
        IDataResult<Post> GetById(int id);
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post); 
        IDataResult<List<PostImageDto>> GetAllImagePosts();
        IDataResult<List<PostTextDto>> GetAllTextPosts();
        IDataResult<List<PostVideoDto>> GetAllVideosPosts();
        IDataResult<List<PostVoiceDto>> GetAllVoicePosts();
        IDataResult<PostImageDto> GetImagePost(int id);
        IDataResult<PostTextDto> GetTextPost(int id);
        IDataResult<PostVideoDto> GetVideosPost(int id);
        IDataResult<PostVoiceDto> GetVoicePost(int id);
    }
}
