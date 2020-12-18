using Microsoft.AspNetCore.Mvc;
using RestWithASP.NET5.Business;
using RestWithASP.NET5.Data.VO;

namespace RestWithASP.NET5.Controllers
{
    [ApiVersion("2")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookBusiness _bookBusiness;

        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult FindById(long id)
        {
            var book = _bookBusiness.FindById(id);

            if (book == null)
            {
                return NotFound("Id not found");
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] BookVO book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            return Ok(_bookBusiness.Create(book));
        }

        [HttpPut]
        public IActionResult Update([FromBody] BookVO book)
        {
            if (book == null)
            {
                return BadRequest();
            }

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
