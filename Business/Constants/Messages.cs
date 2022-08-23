using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        
        
        public static string MaintenanceTime = "Sistem bakımda. Lütfen daha sonra deneyiniz";
        public static string UserNotAdded = "Email ve Password bilgileri boş kalamaz";
        public static string UserAdded = "Hoşgeldiniz";
        public static string UserDeleted = "Hesabınız başarıyla kapatılmıştır";
        public static string SuccessfullRent = "Araçınızı teslim alabilirsiniz";
        public static string UnsuccessfullRent = "Araç müsait değil";
        public static string RentalCarHired = "Kiralamak istediğiniz araba zaten kiralanmış";
        public static string RentalsListed;
        //CUSTOMER
        public static string CustomerAdded = "Müşteri başarılı bir şekilde eklendi.";
        public static string CustomerAddedError = "Müşteri kayıt edilirken bir hata oluştu.";
        public static string CustomerDeleted = "Müşteri başarılı bir şekilde silindi.";
        public static string CustomerUpdated = "Müşteri başarılı bir şekilde güncellendi.";
        public static string CustomerListed = "Müşteriler başarılı bir şekilde listelendi.";
        public static string CustomerIdNull = "Böyle bir müşteri bulunamadı.";
        //COLOR
        public static string ColorAdded = "Renk başarılı bir şekilde eklendi.";
        public static string ColorUpdated = "Renk başarılı bir şekilde güncellendi.";
        public static string ColorDeleted = "Renk başarılı bir şekilde silindi.";
        public static string ColorsListed = "Renk başarılı bir şekilde listelendi.";
        //CAR
        public static string CarAdded = "Araba başarılı bir şekilde eklendi.";
        public static string CarUpdated = "Araba başarılı bir şekilde güncellendi!";
        public static string CarDeleted = "Araba başarılı bir şekilde silindi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarNotFound = "Aranılan araç bulunamadı";
        public static string InsufficientCharacterError = "Araba isminin uzunluğu yeterli değil!";
        //BRAND
        public static string BrandUpdated = "Araba markası başarılı bir şekilde güncellendi!";
        public static string BrandAdded = "Marka başarılı bir şekilde eklendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandDeleted = "Araba markası başarılı bir şekilde silindi.";

        //RENTAL
        public static string RentalAdded = "Araba başarılı bir şekilde kiralandı.";
        public static string CarNotDelivered = "Araba kiralama işlemi başarısız! Araba henüz teslim edilmemiş.";
        public static string RentalUpdated = "Araba kiralaması başarılı bir şekilde güncellendi.";
        public static string RentalUpdatedError = "Araba kiralaması durumu güncellenemedi.";
        public static string RentalDeleted = "Kiralama başarılı bir şekilde silindi.";
        public static string RentalDeletedError = "Kiralama silinirken bir sorun oluştu. Böyle bir kayıt yok.";
        public static string RentalIdNull = "Böyle bir kayıt bulunamadı.";
    }
}
