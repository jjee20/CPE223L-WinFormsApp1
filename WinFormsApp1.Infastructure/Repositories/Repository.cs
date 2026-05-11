using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Infastructure.Data;

namespace WinFormsApp1.Infastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        internal DbSet<T> _dbSet;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> ReadAllAsync()
        {       
            return await _dbSet.ToListAsync();
        }

        public async Task<T> ReadByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }

    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity); // C from Crud
        Task<IEnumerable<T>> ReadAllAsync(); // R from Crud
        Task<T> ReadByIdAsync(int id); // R from Crud, specific for reading by Id. This will be implemented inside each services, because it may require specific logic for each entity.>
        //U from Crud will be implemented inside each services, because it may require specific logic for each entity.
        void Delete(T entity); // D from Crud

        Task SaveAsync();
    }
}
