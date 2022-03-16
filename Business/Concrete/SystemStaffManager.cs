using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SystemStaffManager : ISystemStaffService
    {

        private ISystemStaffDal _systemStaffDal;

        public SystemStaffManager(ISystemStaffDal systemStaffDal)
        {
            _systemStaffDal = systemStaffDal;
        }


        public IDataResult<List<SystemStaff>> GetAll()
        {
            return new SuccessDataResult<List<SystemStaff>>(_systemStaffDal.GetAll(), Messages.SystemStavesListed);
        }

        public IDataResult<SystemStaff> GetById(int id)
        {
            return new SuccessDataResult<SystemStaff>(_systemStaffDal.Get(s => s.Id == id), Messages.SystemStaffListed);
        }

        public IResult Add(SystemStaff staff)
        {
            _systemStaffDal.Add(staff);
            return new SuccessResult(Messages.SystemStaffAdded);
        }

        public IResult Delete(SystemStaff staff)
        {
            _systemStaffDal.Delete(staff);
            return new SuccessResult(Messages.SystemStaffDeleted);
        }

        public IResult Update(SystemStaff staff)
        {
            _systemStaffDal.Update(staff);
            return new SuccessResult(Messages.SystemStaffUpdated);
        }
    }
}
