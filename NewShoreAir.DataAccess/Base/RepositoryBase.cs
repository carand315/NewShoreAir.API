using Microsoft.EntityFrameworkCore;
using NewShoreAir.DataAccess.Common;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace NewShoreAir.DataAccess.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    where T : class
    {
        protected NewShoreAirContext Context
        {
            get
            {
                return dbContext as NewShoreAirContext;
            }
        }

        private readonly DbContext dbContext;

        public RepositoryBase(NewShoreAirContext context)
        {
            dbContext = context;
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().Where(expression);
        }
        //Implemented Common Methods from IRepositoryBase
    }
}
