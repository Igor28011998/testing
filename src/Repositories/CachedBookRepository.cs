using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using CRUD.Repositories.Abstracts;

namespace CRUD.Repositories
{
    public class CachedBookRepository : IBookRepository
    {
        private readonly ICollection<Book> _cache = new List<Book>();

        private readonly DbContext _dbContext;

        public CachedBookRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Get(Guid id)
        {
            if (_cache.Contains(new Book { Id = id }))
            {
                return _cache.FirstOrDefault(x => x.Id == id);
            }

            return await _dbContext.Set<Book>().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}