using System;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Services.Abstracts
{
    public interface IBookService
    {
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task Remove(Guid id);
        Task<Book> Get(Guid id);
    }
}
