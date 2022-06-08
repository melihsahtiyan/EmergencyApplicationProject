using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPostDal : EfEntityRepositoryBase<Post,EmergencyDatabaseContext>, IPostDal
    {
        public List<PostImageDto> GetAllImagePosts()
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join i in context.Images on p.ImageId equals i.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostImageDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        ImagePath = i.ImagePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.ToList();
            }
        }

        public List<PostTextDto> GetAllTextPosts()
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostTextDto()
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.ToList();
            }
        }

        public List<PostVideoDto> GetAllVideosPosts()
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join v in context.Videos on p.VideoId equals v.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostVideoDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        VideoPath = v.VideoPath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.ToList();
            }
        }

        public List<PostVoiceDto> GetAllVoicePosts()
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join v in context.Voices on p.VoiceId equals v.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostVoiceDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        VoicePath = v.VoicePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.ToList();
            }
        }

        public PostImageDto GetImagePostByUserId(int id)
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join i in context.Images on p.ImageId equals i.Id
                    join u in context.Users on p.UserId equals u.Id
                    where p.Id == id
                    select new PostImageDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        ImagePath = i.ImagePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.First();
            }
        }

        public PostTextDto GetTextPostByUserId(int id)
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join u in context.Users on p.UserId equals u.Id
                    where p.Id == id
                    select new PostTextDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.First();
            }
        }

        public PostVideoDto GetVideosPostByUserId(int id)
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join v in context.Videos on p.VideoId equals v.Id
                    join u in context.Users on p.UserId equals u.Id
                    where p.Id == id
                    select new PostVideoDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        VideoPath = v.VideoPath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.First();
            }
        }

        public PostVoiceDto GetVoicePostByUserId(int id)
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join v in context.Voices on p.VoiceId equals v.Id
                    join u in context.Users on p.UserId equals u.Id
                    where p.Id == id
                    select new PostVoiceDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        VoicePath = v.VoicePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.First();
            }
        }
    }
}
