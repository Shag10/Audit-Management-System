using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditManagementPortalClientMVC.Models.Context
{
    public class AuditDbContext : DbContext
    {
        public AuditDbContext(DbContextOptions<AuditDbContext> options) : base(options)
        {

        }


        public DbSet<StoreAuditResponse> storeAuditResponses { set; get; }

        public class DesignTimeBMDbContext : IDesignTimeDbContextFactory<AuditDbContext>
        {
            public AuditDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AuditDbContext>();
                // pass your design time connection string here
                optionsBuilder.UseSqlServer(@"Data Source=Project\SQLEXPRESS;Initial Catalog=AuditMVCPortal;persist security info=True;User Id=sab;Password=shag@123;");
                return new AuditDbContext(optionsBuilder.Options);
            }
        }

    }
}
