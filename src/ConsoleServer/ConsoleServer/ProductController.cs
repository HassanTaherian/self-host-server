using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleServer
{
    public class ProductController : ApiController
    { 
        public IEnumerable<Product> GetAllProducts()
        {
            return Product.GetProducts();
        }

        public IHttpActionResult GetProductById(int id)
        {
            var products = Product.GetProducts();
            var requestedProduct = products.FirstOrDefault(product => product.Id == id);

            if (requestedProduct is null)
            {
                return NotFound();
            }

            return Ok(requestedProduct);
        }
    }
}
