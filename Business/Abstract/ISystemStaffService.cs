using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISystemStaffService
    {
        IDataResult<List<SystemStaff>> GetAll();
        IDataResult<SystemStaff> GetById(int id);
        IResult Add(SystemStaff staff);
        IResult Delete(SystemStaff staff);
        IResult Update(SystemStaff staff);
    }
}
