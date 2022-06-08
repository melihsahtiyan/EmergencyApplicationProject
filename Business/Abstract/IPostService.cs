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
        IDataResult<List<Post>> GetAllPosts();
        IDataResult<List<Post>> GetAllByCategory(int categoryId);
        IDataResult<Post> GetById(int id);
        IDataResult<Post> GetByUserIdAndLatestDate(int userId);
        IDataResult<Post> GetByDateLatest();
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post); 
        IDataResult<List<PostImageDto>> GetAllImagePosts();
        IDataResult<List<PostTextDto>> GetAllTextPosts();
        IDataResult<List<PostVideoDto>> GetAllVideosPosts();
        IDataResult<List<PostVoiceDto>> GetAllVoicePosts();
        IDataResult<PostImageDto> GetImagePostByUserId(int id);
        IDataResult<PostTextDto> GetTextPostByUserId(int id);
        IDataResult<PostVideoDto> GetVideosPostByUserId(int id);
        IDataResult<PostVoiceDto> GetVoicePostByUserId(int id);
    }
}
