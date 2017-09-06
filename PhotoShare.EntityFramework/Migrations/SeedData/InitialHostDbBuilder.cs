using PhotoShare.EntityFramework;
using EntityFramework.DynamicFilters;

namespace PhotoShare.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly PhotoShareDbContext _context;

        public InitialHostDbBuilder(PhotoShareDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
