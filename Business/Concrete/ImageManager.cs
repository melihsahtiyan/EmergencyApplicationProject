using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Business.Abstract;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {

        private IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll());
        }

        public IDataResult<Image> GetById(int id)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(i => i.Id == id));
        }

        public IResult Add(IFormFile file, Image image)
        {
            image.ImagePath = FormFileHelper.Add(file,"images");
            image.Date = DateTime.Now;
            _imageDal.Add(image);
            return new SuccessResult("Image has been added");
        }

        public IResult Update(IFormFile file, Image image)
        {
            var result = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../wwwroot")) +
                         _imageDal.Get(i => i.Id == image.Id).ImagePath;
            image.ImagePath = FormFileHelper.Update(file, result, "images");
            image.Date = DateTime.Now;
            _imageDal.Update(image);
            return new SuccessResult("Image has been added");
        }

        public IResult Delete(Image image)
        {
            FormFileHelper.Delete(image.ImagePath);
            _imageDal.Delete(image);
            return new SuccessResult("Image has been added");
        }
    }
}
