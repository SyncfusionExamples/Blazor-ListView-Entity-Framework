using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EFListView.Shared.DataAccess;
using EFListView.Shared.Models;
using System;

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
        public object Post([FromBody]Products product)
        {
            db.AddProduct(product);
            return product;
        }

        [HttpDelete]
        public void Delete([FromBody]Products product)
        {
            db.DeleteProduct(product);
        }
    }
}
