
using CityInfo.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Api.Repository
{

    //Repository
    public class GenericRepository<T, TContext> : IGenericRepository<T, TContext>
    where T : class
    where TContext : DbContext
    { 
        protected readonly MyDbContext _myDbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
            _dbSet = myDbContext.Set<T>();
        
        }
        public virtual async Task<bool> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

         var result=   await _myDbContext.SaveChangesAsync();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public virtual async Task<bool> DeleteAsync(int Id)
        {
            
            var entity = await _dbSet.FindAsync(Id);
            if (entity != null)
            {
             _dbSet.Remove(entity);
          var results=  await _myDbContext.SaveChangesAsync();
                if (results == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
           var result= await _dbSet.ToListAsync();
            return result;
        }

        public virtual async Task<T> GetIDbAsync(int Id)
        {
         return   await _dbSet.FindAsync(Id);
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);

          var result=  await _myDbContext.SaveChangesAsync();
            if(result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
}
