using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
			
        }

        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<AssetEntity> AssetEntities => Set<AssetEntity>();

        public DbSet<AdminEntity> AdminEntities => Set<AdminEntity>();
        public DbSet<RequestEntity> RequestEntities => Set<RequestEntity>();
        public DbSet<AuditEntity> AuditEntities => Set<AuditEntity>();
        public DbSet<EmployeeEntity> EmployeeEntities => Set<EmployeeEntity>();
        
    }
}
