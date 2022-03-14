using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class SystemStaff : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StaffNumber { get; set; }
        public bool Status { get; set; }
    }
}
