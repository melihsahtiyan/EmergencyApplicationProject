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
        public PostImageDto GetImagePost(int id);
        public PostTextDto GetTextPost(int id);
        public PostVideoDto GetVideosPost(int id);
        public PostVoiceDto GetVoicePost(int id);
    }
}
