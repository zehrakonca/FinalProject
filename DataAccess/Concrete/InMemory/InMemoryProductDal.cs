using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product
                {
                    CategoryId = 1, ProductId = 1,
                    ProductName = "Bardak", UnitPrice = 15,
                    UnitsInStock = 15
                },
                new Product
                {
                    CategoryId = 2, ProductId = 2,
                    ProductName = "Kamera", UnitPrice = 1500,
                    UnitsInStock = 25
                },
                new Product
                {
                    CategoryId = 2, ProductId = 3,
                    ProductName = "Telefon", UnitPrice = 2500,
                    UnitsInStock = 40
                },
                new Product
                {
                    CategoryId = 2, ProductId = 4,
                    ProductName = "Klavye", UnitPrice = 75,
                    UnitsInStock = 60
                },
                new Product
                {
                    CategoryId = 2, ProductId = 5,
                    ProductName = "Fare", UnitPrice = 30,
                    UnitsInStock = 1
                }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //} bu şekildede olabilir. linq ile kullanım aşağıda yazılı. 
            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryId == categoryID).ToList();
        }

        public void Update(Product product)
        {
            // gönderilen ürün idsine sahip ürünü bul. 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName  = product.ProductName;
            productToUpdate.CategoryId   = product.CategoryId;
            productToUpdate.UnitPrice    = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
