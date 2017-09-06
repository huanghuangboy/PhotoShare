using System.Data.Common;
using Abp.Zero.EntityFramework;
using PhotoShare.Authorization.Roles;
using PhotoShare.Authorization.Users;
using PhotoShare.MultiTenancy;

namespace PhotoShare.EntityFramework
{
    public class PhotoShareDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PhotoShareDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PhotoShareDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PhotoShareDbContext since ABP automatically handles it.
         */
        public PhotoShareDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PhotoShareDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public PhotoShareDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
