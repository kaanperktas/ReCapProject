
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
            CarDetails();

        }

        private static void CarDetails()
        {
            var carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.BrandName + " " + c.ColorName + " " + c.CarName + " " + c.DailyPrice);
            }

           /* CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var a in carManager1.GetAll())
            {
                Console.WriteLine(a.CarName);
            } */
        }
    }
    }

