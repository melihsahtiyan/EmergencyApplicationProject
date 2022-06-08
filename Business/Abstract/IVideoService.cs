using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IVideoService
    {
        IDataResult<List<Video>> GetAll();
        IDataResult<Video> GetById(int id);
        IDataResult<Video> GetByUserId(int userId);
        IResult Add(Video video);
        IResult Delete(Video video);
        IResult Update(Video video);
    }
}
