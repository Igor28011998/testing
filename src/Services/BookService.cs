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

        public Task Create(Book book)
        {
            book.Id = Guid.NewGuid();
            if (book.Name.Contains("Pablo"))
            {
                throw new Exception("Sosi hui");
            }

            return _repository.Create(book);
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}