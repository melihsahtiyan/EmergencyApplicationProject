using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> GetById(int id);
        IDataResult<Image> GetByUserId(int userId);
        IResult Add(IFormFile file, Image image);
        IResult Update(IFormFile file, Image image);
        IResult Delete(Image image);

    }
}
