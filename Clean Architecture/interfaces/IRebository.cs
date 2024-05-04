using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.interfaces
{
    public interface IRebository<TEntity> : IRebository<TEntity> where TEntity : class
    {
        ValueTask<TEntity> AddAsync(TEntity entity);
        ValueTask<TEntity> Get(String EntityId);
        ValueTask<IEnumerable<TEntity>> GetAll();
        ValueTask<TEntity> UpdateAsync (TEntity entity);
        ValueTask<TEntity> DeleteAsync (TEntity entity);

        // S
    }
}
