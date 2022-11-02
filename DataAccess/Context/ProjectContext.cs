using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    public class ProjectContext : IdentityDbContext<IdentityUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-HBSN76P;database=BilgeOtelDb;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExtraService> ExtraServices { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestRegistration> GuestRegistrations { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<ReceptionReservation> ReceptionReservations{ get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Room> Rooms  { get; set; }
        public DbSet<RoomPicture> RoomPictures  { get; set; }
        public DbSet<RoomType>RoomTypes  { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<ServicePack>ServicePacks  { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<UseOfExtraService>UseOfExtraServices  { get; set; }
        public DbSet<WebReservation>WebReservations  { get; set; }
        public DbSet<WorkSchedule>WorkSchedules  { get; set; }

}
}
