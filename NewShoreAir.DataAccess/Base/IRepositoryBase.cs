using System;
using System.Linq;
using System.Linq.Expressions;

namespace NewShoreAir.DataAccess.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        // Add Common Repo Methods such as Add, Delete, Get...
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
    }
}