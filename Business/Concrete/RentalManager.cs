using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(x => x.CarId == rental.CarId).OrderByDescending(r => r.Id).FirstOrDefault();
            //var kayit = result.FirstOrDefault(r => r. == rental.Id);
            if (result != null && result.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarNotDelivered);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

        }

        public IResult Delete(Rental rental)
        {
            try
            {
                Rental result = _rentalDal.Get(x => x == rental);
                if (result != null)
                {
                    _rentalDal.Delete(rental);
                    return new SuccessResult(Messages.RentalDeleted);
                }
                else
                {
                    return new ErrorResult(Messages.RentalIdNull);
                }
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.RentalDeletedError);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetRentalById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
        
        public IDataResult<Rental> GetByReturnDateNull(int carId)
        {
            var result = _rentalDal.GetAll().FirstOrDefault(x => x.CarId == carId && x.ReturnDate == null);
            return new SuccessDataResult<Rental>(result);
        }
    }
}
