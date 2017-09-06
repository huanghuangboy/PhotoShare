using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace PhotoShare.EntityFramework.Repositories
{
    public abstract class PhotoShareRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PhotoShareDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PhotoShareRepositoryBase(IDbContextProvider<PhotoShareDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PhotoShareRepositoryBase<TEntity> : PhotoShareRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PhotoShareRepositoryBase(IDbContextProvider<PhotoShareDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
