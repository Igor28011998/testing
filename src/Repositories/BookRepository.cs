using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using CRUD.Repositories.Abstracts;

namespace CRUD.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContext _dbContext;

        public BookRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> Create(Book book)
        {
            _dbContext.Add(book);
            await _dbContext.SaveChangesAsync();

            return book;
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(Expression<Func<Book, bool>> expression)
        {
            return _dbContext.Set<Book>().FirstOrDefaultAsync(expression);
        }
    }
}