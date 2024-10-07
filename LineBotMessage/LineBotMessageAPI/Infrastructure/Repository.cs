using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace LineBotMessageAPI.Infrastructure;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationContext _applicationContext;
    private readonly DbSet<T> _entitis;

    public Repository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
        _entitis = _applicationContext.Set<T>();
    }
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entitis.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _entitis.FindAsync(id);

    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _entitis.Where(predicate).ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _entitis.AddAsync(entity);
        
    }

    public void Update(T entity)
    {
        _entitis.Update(entity);
    }

    public void Remove(T entity)
    {
        _entitis.Remove(entity);
    }
}