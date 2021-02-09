using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;

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
                    CategoryID = 1, ProductID = 1,
                    ProductName = "Bardak", UnitPrice = 15,
                    UnitsInStock = 15
                },
                new Product
                {
                    CategoryID = 2, ProductID = 2,
                    ProductName = "Kamera", UnitPrice = 1500,
                    UnitsInStock = 25
                },
                new Product
                {
                    CategoryID = 2, ProductID = 3,
                    ProductName = "Telefon", UnitPrice = 2500,
                    UnitsInStock = 40
                },
                new Product
                {
                    CategoryID = 2, ProductID = 4,
                    ProductName = "Klavye", UnitPrice = 75,
                    UnitsInStock = 60
                },
                new Product
                {
                    CategoryID = 2, ProductID = 5,
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
            productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            // gönderilen ürün idsine sahip ürünü bul. 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName  = product.ProductName;
            productToUpdate.CategoryID   = product.CategoryID;
            productToUpdate.UnitPrice    = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
