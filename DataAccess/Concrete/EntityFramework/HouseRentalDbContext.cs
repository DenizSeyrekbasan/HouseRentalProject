using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesnesi db tablolari ile proje classlarini baglama islemi
    public class HouseRentalDbContext : DbContext //DbContext EF'den gelen base nesne
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //projemizin hangi veritabani ile iliskili oldugunu belirttigimiz yer
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=HouseRental;Trusted_Connection=True;");
        }

        public DbSet<House> Houses { get; set; } //DbSet ile entitieslerimizi ve table'larimizi eslestiriyoruz
        public DbSet<HouseCategory> HouseCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
