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
    public class VideoManager : IVideoService
    {

        private IVideoDal _videoDal;

        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }


        public IDataResult<List<Video>> GetAll()
        {
            return new SuccessDataResult<List<Video>>(_videoDal.GetAll(), Messages.VideosPosted);
        }

        public IDataResult<Video> GetById(int id)
        {
            return new SuccessDataResult<Video>(_videoDal.Get(v => v.Id == id), Messages.VideoListed);
        }

        public IResult Add(Video video)
        {
            _videoDal.Add(video);
            return new SuccessResult(Messages.VideoAdded);
        }

        public IResult Delete(Video video)
        {
            _videoDal.Delete(video);
            return new SuccessResult(Messages.VideoDeleted);
        }

        public IResult Update(Video video)
        {
            _videoDal.Update(video);
            return new SuccessResult(Messages.VideoUpdated);
        }
    }
}
