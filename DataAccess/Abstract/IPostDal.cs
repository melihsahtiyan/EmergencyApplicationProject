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
        public PostImageDto GetImagePostByUserId(int id);
        public PostTextDto GetTextPostByUserId(int id);
        public PostVideoDto GetVideosPostByUserId(int id);
        public PostVoiceDto GetVoicePostByUserId(int id);
    }
}
