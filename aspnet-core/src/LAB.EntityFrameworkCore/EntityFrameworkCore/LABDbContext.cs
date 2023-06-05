using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;
using LAB.CarModel;
using LAB.Car;


namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<CarModels> CarModels { get; set; }
        public DbSet<Cars> Cars { get; set; }

        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }
    }
}
