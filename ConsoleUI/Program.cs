
using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var carManager = new CarManager(new EfCarDal());

            var newCar = new Car{
                Id = 11,
                BrandId = 3,
                ColorId = 2,
                ModelYear = 2019,
                DailyPrice = 0,
                Description = "N"
             };

             carManager.Add(newCar);

        }
    }
    }

