using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        //Mesasge oldugu icin surekli newlenmesine gerek yok
        //static verildiginde newlenmiyor
        public static string HouseAdded = "Ev ilana eklendi !";
        public static string HouseNameInvalid = "Ev ekleme islemi BASARISIZ, Lutfen en az 3 karakter giriniz !";
        public static string HousesListed = "Evler listeleniyor !";
        public static string MaintanceTime = "Sistem bakimda !";


        public static string CityAdded = "Sehir eklendi !";
        public static string CityDeleted = "Sehir silindi !";
        public static string CityUpdated = "Sehir duzenlendi !";
        public static string CityGetAll = "Sehirler listendi !";

        public static string UserAdded = "Kullanici ekleme basarili !";
        public static string UserDeleted = "Kullanici silme basarili !";
        public static string UserUpdated = "Kullanici duzenleme basarili !";
        public static string UserListed = "Kullanicilar listeleniyor !";
    }
}
