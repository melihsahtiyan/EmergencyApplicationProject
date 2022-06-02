using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public int? ImageId { get; set; }
        public int? VideoId { get; set; }
        public int? VoiceId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
