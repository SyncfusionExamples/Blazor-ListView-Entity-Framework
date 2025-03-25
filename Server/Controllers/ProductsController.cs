using EFListView.Shared.DataAccess;
using EFListView.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFListView.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        DataAccessLayer db = new DataAccessLayer();
        [HttpGet]
        public object Get()
        {
            return db.GetAllProducts().ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Products product)
        {
            if (product == null || string.IsNullOrWhiteSpace(product.ProductName))
            {
                return BadRequest("Invalid product data.");
            }

            db.AddProduct(product);
            return Ok(await db.GetAllProducts().ToListAsync());
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var product = await db.GetAllProducts().FirstOrDefaultAsync(p => p.ProductID == id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            db.DeleteProduct(product);
            return Ok(await db.GetAllProducts().ToListAsync());
        }

    }
}
