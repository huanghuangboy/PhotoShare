using System.Linq;
using PhotoShare.EntityFramework;
using PhotoShare.MultiTenancy;

namespace PhotoShare.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly PhotoShareDbContext _context;

        public DefaultTenantCreator(PhotoShareDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
