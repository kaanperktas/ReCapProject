using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapCarContext context = new ReCapCarContext())
            {
                var result = from c in context.Car
                             join clr in context.Color
                             on c.ColorId equals clr.ColorId
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();

            }
        }
    }
}
