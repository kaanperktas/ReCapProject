
using Business.Abstract;
using Business.Concrete;
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

            RentalTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer { UserId = 2, CompanyName = "SolidTeam" });
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

          //  userManager.Add(new User {Id = 1, Email = "kaanperktas@gmail.com", FirstName = "Kaan", LastName = "Perktas", Password ="12321321" });
            userManager.Add(new User {Id = 2, Password ="1231231", FirstName = "Mustafa Murat", LastName = "Coşkun", Email = "Mustafacoşkun34@gmail.com" });
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Update(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2022, 06, 15), ReturnDate = DateTime.Now});

            var result = rentalManager.GetAll();

            foreach (var rental in result.Data)
            {
                Console.WriteLine("{0} - {1} - {2} ", rental.CarId, rental.CustomerId, rental.RentDate);
            }
        }
        
        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            foreach (var carDetail in result.Data)
            {
                if (result.Success)
                {
                    Console.WriteLine("{0} - {1} - {2}", carDetail.Description.Trim(), carDetail.BrandName.Trim(), carDetail.ColorName.Trim());
                    Console.WriteLine("--------------");
                    Console.WriteLine(result.Message);
                }

            }
        }
    }
    }

