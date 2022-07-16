using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        public InMemory()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=600000,Description="Bmw", ModelYear=2005},
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=500000,Description="Audi", ModelYear=2015},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=800000,Description="Limuzin", ModelYear=2020},
                new Car{Id=4,BrandId=3,ColorId=2,DailyPrice=70000,Description="Opel Corsa", ModelYear=2018},
                new Car{Id=5,BrandId=1,ColorId=3,DailyPrice=80000,Description="Fiat Egea", ModelYear=2021},

            };
        }


        List<Car> _car;
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;


        }
    }
}
