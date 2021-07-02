using System;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Repositories.Abstracts
{
    public interface IBookRepository
    {
        Task Create(Book book);
        Task Update(Book book);
        Task Remove(Guid id);
        Task<Book> Get(Guid id);
    }
}