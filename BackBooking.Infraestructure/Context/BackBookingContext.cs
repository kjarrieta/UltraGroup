using BackBooking.Domain.Entities;
using BackBooking.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBooking.Infraestructure.Context
{
    public class BackBookingContext : DbContext
    {
        public BackBookingContext(DbContextOptions<BackBookingContext> options): base(options) { }

        public DbSet<Hotel> THotel { get; set; }
        public DbSet<RoomXHotel> TRoomXHotel { get; set; }
        public DbSet<Booking> TBooking { get; set; }
        public DbSet<Guest> TGuest { get; set; }      
        public DbSet<UserAgency> TUserAgency { get; set; }        
        public DbSet<UserGuest> TUserGuest { get; set; }        
        public DbSet<Agency> TAgency { get; set; }
        public DbSet<DetailBookingXGuest> TDetailBookingXGuest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailBookingXGuest>()
                .HasKey(rh => new { rh.IdBooking, rh.GuestIdDocument });                         

            base.OnModelCreating(modelBuilder);
        }


    }

}
