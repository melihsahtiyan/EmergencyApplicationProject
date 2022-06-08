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
    public class VoiceManager : IVoiceService
    {

        private IVoiceDal _voiceDal;

        public VoiceManager(IVoiceDal voiceDal)
        {
            _voiceDal = voiceDal;
        }


        public IDataResult<List<Voice>> GetAll()
        {
            return new SuccessDataResult<List<Voice>>(_voiceDal.GetAll(), Messages.VoicesListed);
        }

        public IDataResult<Voice> GetById(int id)
        {
            return new SuccessDataResult<Voice>(_voiceDal.Get(v => v.Id == id), Messages.VoiceListed);
        }

        public IDataResult<Voice> GetByUserId(int userId)
        {
            return new SuccessDataResult<Voice>(_voiceDal.Get(v => v.UserId == userId), Messages.VoiceListed);
        }

        public IResult Add(Voice voice)
        {
            _voiceDal.Add(voice);
            return new SuccessResult(Messages.VoiceAdded);
        }

        public IResult Delete(Voice voice)
        {
            _voiceDal.Delete(voice);
            return new SuccessResult(Messages.VoiceDeleted);
        }

        public IResult Update(Voice voice)
        {
            _voiceDal.Update(voice);
            return new SuccessResult(Messages.VoiceUpdated);
        }
    }
}
