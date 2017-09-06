using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using PhotoShare.EntityFramework;

namespace PhotoShare.Migrator
{
    [DependsOn(typeof(PhotoShareDataModule))]
    public class PhotoShareMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PhotoShareDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}