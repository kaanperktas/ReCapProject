
using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.BrandName + c.ColorName + c.CarName + c.DailyPrice);
            }

        }
    }
    }

