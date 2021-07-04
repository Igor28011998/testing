using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Repositories.Abstracts
{
    public interface IBookRepository
    {
        Task<Book> Create(Book book);
        Task<Book> Update(Book book);
        Task<Book> Remove(Guid id);
        Task<Book> Get(Expression<Func<Book, bool>> expression);
    }
}