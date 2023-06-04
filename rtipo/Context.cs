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
    internal class Context : DbContext
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

        DbSet<Animal> Animals { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Inspection> Inspections { get; set; }
        DbSet<Locality> Localities { get; set; }
        DbSet<MunicipalContract> MunicipalContracts { get; set; }
        DbSet<Organisation> Organisations { get; set; }
        DbSet<OrganisationType> OrganisationTypes { get; set; }
        DbSet<OwnerSign> OwnerSigns { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }

    }
}
