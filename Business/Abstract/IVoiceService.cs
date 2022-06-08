using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IVoiceService
    {
        IDataResult<List<Voice>> GetAll();
        IDataResult<Voice> GetById(int id);
        IDataResult<Voice> GetByUserId(int userId);
        IResult Add(Voice voice);
        IResult Delete(Voice voice);
        IResult Update(Voice voice);
    }
}
