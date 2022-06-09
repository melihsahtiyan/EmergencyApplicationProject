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
        public List<PostDetailDto> GetAllPostDetails()
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join i in context.Images on p.ImageId equals i.Id
                    join video in context.Videos on p.VideoId equals video.Id
                    join voice in context.Voices on p.VoiceId equals voice.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostDetailDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        ImagePath = i.ImagePath,
                        VideoPath = video.VideoPath,
                        VoicePath = voice.VoicePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.ToList();
            }
        }

        public PostDetailDto GetPostDetailByUserId(int id)
        {
            using (EmergencyDatabaseContext context = new EmergencyDatabaseContext())
            {
                var result = from p in context.Posts
                    join ctg in context.Categories on p.CategoryId equals ctg.Id
                    join i in context.Images on p.ImageId equals i.Id
                    join video in context.Videos on p.VideoId equals video.Id
                    join voice in context.Voices on p.VoiceId equals voice.Id
                    join u in context.Users on p.UserId equals u.Id
                    select new PostDetailDto
                    {
                        Id = p.Id,
                        CategoryName = ctg.CategoryName,
                        Description = p.Description,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        IdentityNumber = u.IdentityNumber,
                        ImagePath = i.ImagePath,
                        VideoPath = video.VideoPath,
                        VoicePath = voice.VoicePath,
                        Latitude = p.Latitude,
                        Longitude = p.Longitude
                    };
                return result.First();
            }
        }

    }
}
