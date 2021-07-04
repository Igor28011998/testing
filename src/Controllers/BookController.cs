using System;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using CRUD.Services.Abstracts;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var book = await _bookService.Get(id);

            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> Create(Book book)
        {
            var created = await _bookService.Create(book);

            return Ok(created);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Book>> Remove(Guid id)
        {
            var book = await _bookService.Remove(id);
            if (book==null)
            {
                return NotFound();
            }

            return Ok(book);
        }
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, Book book)
        {
            if (id !=book.Id)
            {
                return BadRequest();
            }
            await _bookService.Update(book);
            return NoContent();
        }
    }
}