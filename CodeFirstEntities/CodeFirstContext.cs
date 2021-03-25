using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoenixCust.CodeFirstEntities
{
    public class CodeFirstContext: DbContext
    {

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
           : base(options)
        {
        }

        public DbSet <CodeFirstCustomer> CodeFirstCustomers { get; set; }

        public DbSet <Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodeFirstCustomer>().HasData(
                new CodeFirstCustomer
                {
                    Id = 1,
                    Custname = "Dave Byers",
                    Busname = "Applacres,Inc.",
                    Custcellphone = "812-279-9721",
                    Custemailaddress = "applacresinc@gmail.com",
                    Password = "spring123"
                });
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    CustomerId = 1,
                    ProjectName = "applacres.net",
                    Status = "quarterly"
                });
        }
    }




}
