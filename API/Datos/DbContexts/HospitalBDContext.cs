using Datos.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DbContexts
{
    public class HospitalBDContext : DbContext
    {
        public HospitalBDContext(DbContextOptions<HospitalBDContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }



        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Especialities> Especialities{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(
                    new Roles() { id = 1, name = "Administrador" },
                    new Roles() { id = 2, name = "Doctor" },
                    new Roles() { id = 3, name = "Cliente" }
                );


            modelBuilder.Entity<Users>().HasData(
                    new Users() { id = 1, username = "admin_test", password = "12345", role_id = 1 },
                    new Users() { id = 2, username = "doctor_test", password = "12345", role_id = 2 },
                    new Users() { id = 3, username = "client_test", password = "12345", role_id = 3 }
                );


        }
    }
}
