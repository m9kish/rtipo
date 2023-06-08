using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using rtipo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace rtipo
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Migrate();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=animals;username=root;password=",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Locality> Localities { get; set; }
        public DbSet<MunicipalContract> MunicipalContracts { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<OrganisationType> OrganisationTypes { get; set; }
        public DbSet<OwnerSign> OwnerSigns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



    }
}
