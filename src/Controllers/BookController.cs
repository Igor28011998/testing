using System;
using System.Threading.Tasks;
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
    }
}