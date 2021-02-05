using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RESTAPI.Controllers.Model;
using RESTAPI.Business;

namespace RESTAPI.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {


        private readonly ILogger<BookController> _logger1;
        private IBookBusiness _bookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger1 = logger;
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult GetBook()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(long id)
        {
            var book = _bookBusiness.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBusiness.Create(book));

        }

        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBusiness.Update(book));

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return NoContent();

        }
    }
}
