using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IPostDal : IEntityRepository<Post>
    {
        public List<PostImageDto> GetAllImagePosts();
        public List<PostTextDto> GetAllTextPosts();
        public List<PostVideoDto> GetAllVideosPosts();
        public List<PostVoiceDto> GetAllVoicePosts();
        public PostImageDto GetImagePostByCustomerId(int id);
        public PostTextDto GetTextPostByCustomerId(int id);
        public PostVideoDto GetVideosPostByCustomerId(int id);
        public PostVoiceDto GetVoicePostByCustomerId(int id);
    }
}
