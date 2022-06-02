using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Video : IEntity
    {
        public int Id { get; set; }
        public string VideoPath { get; set; }
        public DateTime Date { get; set; }
    }
}
