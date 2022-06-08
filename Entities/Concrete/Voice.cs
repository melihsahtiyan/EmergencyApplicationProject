using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Voice : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string VoicePath { get; set; }
        public DateTime Date { get; set; }
    }
}
