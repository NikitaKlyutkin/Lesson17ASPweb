using Lesson17ASPweb.Models.Domain;
using System.Collections.Generic;

namespace Lesson17ASPweb.Services
{
    public interface IActionWithProductService
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public void ReplaceProduct(int idProduct, Product product);
        public decimal SummAllProducts();
    }
}
