using System;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.Services.Abstracts
{
    public interface IBookService
    {
        Task<Book> Create(Book book);
        Task<Book> Update(Book book);
        Task<Book> Remove(Guid id);
        Task<Book> Get(Guid id);
    }
}
