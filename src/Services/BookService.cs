using System;
using System.Threading.Tasks;
using CRUD.Models;
using CRUD.Repositories.Abstracts;
using CRUD.Services.Abstracts;

namespace CRUD.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public Task<Book> Create(Book book)
        {
            book.Id = Guid.NewGuid();

            return _repository.Create(book);
        }

        public Task<Book> Update(Book book)
        {
            return _repository.Update(book);
        }

        public Task<Book> Remove(Guid id)
        {
            return _repository.Remove(id);
        }

        public Task<Book> Get(Guid id)
        {
            return _repository.Get(x => x.Id == id);
        }
    }
}