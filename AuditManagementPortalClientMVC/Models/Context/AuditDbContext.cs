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
                optionsBuilder.UseSqlServer(@"Server=tcp:audit-management-shubhang.database.windows.net,1433;Initial Catalog=AuditMVCPortal;Persist Security Info=False;User ID=sab;Password=shag@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                return new AuditDbContext(optionsBuilder.Options);
            }
        }

    }
}
