using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Day4_Assignment.Models;
namespace Day4_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private ProductDbContext _dbConext;

        public ProductApiController(ProductDbContext dbContext)
        {
            _dbConext = dbContext;
        }

        // Read All
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_dbConext.Products.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product obj)
        {
            _dbConext.Products.Add(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Emp Details added to db" });
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            _dbConext.Entry(obj).State = EntityState.Modified;
            _dbConext.SaveChanges();
            return Ok(new { result = "Emp Details updated to db" });
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Product obj = _dbConext.Products.Find(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested employee details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Product obj = _dbConext.Products.Find(id);
            _dbConext.Products.Remove(obj);
            _dbConext.SaveChanges();
            return Ok(new { result = "Emp Details deleted from db" });
        }
    }
}
