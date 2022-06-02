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
        IDataResult<Post> GetByCustomerIdAndLatestDate(int customerId);
        IDataResult<Post> GetByDateLatest();
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post); 
        IDataResult<List<PostImageDto>> GetAllImagePosts();
        IDataResult<List<PostTextDto>> GetAllTextPosts();
        IDataResult<List<PostVideoDto>> GetAllVideosPosts();
        IDataResult<List<PostVoiceDto>> GetAllVoicePosts();
        IDataResult<PostImageDto> GetImagePostByCustomerId(int id);
        IDataResult<PostTextDto> GetTextPostByCustomerId(int id);
        IDataResult<PostVideoDto> GetVideosPostByCustomerId(int id);
        IDataResult<PostVoiceDto> GetVoicePostByCustomerId(int id);
    }
}
