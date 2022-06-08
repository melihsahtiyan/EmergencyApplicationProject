using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class PostTextDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CategoryName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
